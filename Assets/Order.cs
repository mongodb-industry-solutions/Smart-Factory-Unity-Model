using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine;
using Realms;
using Realms.Sync;
using MongoDB.Bson;


public class Order : MonoBehaviour
{

    private static Realm realm;
    private static App realmApp = App.Create(Constants.Realm.AppId); 
    public static User syncUser;
    private IDisposable listenerToken;
    public  Animator myWhiteAnimator;
    public  Animator myRedAnimator;
    public  Animator myBlueAnimator;

     

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  GameObject BlueButton;
    public  GameObject RedButton;
    public  GameObject WhiteButton;


    public async void OnBlueButtonClick(){
                Debug.Log(Constants.Realm.flag);
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);
                realm.Write(() =>
                {
                    realm.Add(new digital_twin_orders()
                    {
                        Id = ObjectId.GenerateNewId(),
                        ShipFrom="North York",
                        ShipTo="Toronto",
                        Color = "blue",
                        UserId ="DT",
                        FirstName="H",
                        LastName="A",
                        OrderStatus="Order Submitted",
                        TimeStamp = DateTimeOffset.Now
                    });
                });
                
                SetMovementListener(realm);
                if (Constants.Realm.flag == false){
                    Constants.Realm.flag = true;
                  //  SetMovementListener(realm);
                }
    }

    public  async void OnRedButtonClick(){
                Debug.Log(Constants.Realm.flag);
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);
                realm.Write(() =>
                {
                    realm.Add(new digital_twin_orders()
                    {
                        Id = ObjectId.GenerateNewId(),
                        ShipFrom="North York",
                        ShipTo="Toronto",
                        Color = "red",
                        UserId ="DT",
                        FirstName="H",
                        LastName="A",
                        OrderStatus="Order Submitted",
                        TimeStamp = DateTimeOffset.Now
                    });
                });
                SetMovementListener(realm);

                if (Constants.Realm.flag == false){
                    Constants.Realm.flag = true;
                   // SetMovementListener(realm);
                }
    }

        public  async void OnWhiteButtonClick(){
                Debug.Log(Constants.Realm.flag);
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);
                realm.Write(() =>
                {
                    realm.Add(new digital_twin_orders()
                    {
                        Id = ObjectId.GenerateNewId(),
                        ShipFrom="North York",
                        ShipTo="Toronto",
                        Color = "white",
                        UserId ="DT",
                        FirstName="H",
                        LastName="A",
                        OrderStatus="Order Submitted",
                        TimeStamp = DateTimeOffset.Now
                    });
                });
                SetMovementListener(realm);

                if (Constants.Realm.flag == false){
                    Constants.Realm.flag = true;
                   // SetMovementListener(realm);
                }

    }

    // GetRealm() returns a realm instance
   /* private static Realm GetRealm()
    {
        return Realm.GetInstance();

    }
    */

    private static async Task<Realm> GetRealm(User loggedInUser)
    {
       var syncConfiguration = new PartitionSyncConfiguration("DTPartition", loggedInUser);
       return await Realm.GetInstanceAsync(syncConfiguration);

        //Flexible Sync code
        /*  var config = new FlexibleSyncConfiguration(loggedInUser)  
            {
                PopulateInitialSubscriptions = (realm) =>
                {
                    var myOrders = realm.All<order>().Where(n => n.UserId == "DT");
                    realm.Subscriptions.Add(myOrders);
                }
            };
            return await Realm.GetInstanceAsync(config);*/



    }



    private void StartAnimations(int[] insertedIndices, Realm realm)
{
     Debug.Log("inside Start Animations");
     Debug.Log(insertedIndices.Length);
    foreach (var i in insertedIndices)
    {
        var newMessage = realm.All<mqtt>().ElementAt(i);
        Debug.Log(newMessage.Topic);

        if(newMessage.State=="ORDERED" && newMessage.Type=="WHITE" && newMessage.Topic=="f/i/order"){
            myWhiteAnimator.SetTrigger("start_white");
            Debug.Log("start white animation");
        }

        else if (newMessage.State=="ORDERED" && newMessage.Type=="RED" && newMessage.Topic=="f/i/order"){
            myRedAnimator.SetTrigger("start_red");
            Debug.Log("start red animation");
        }

        else if (newMessage.State=="ORDERED" && newMessage.Type=="BLUE" && newMessage.Topic=="f/i/order"){
            Debug.Log("start blue animation");
        }

     
    }
}

    public void SetMovementListener(Realm realm)
    {
      listenerToken = realm.All<mqtt>()
        .SubscribeForNotifications((sender, changes, error) =>
        {
            if (error != null)
            {
                Debug.Log("an error occurred while listening for messages :" + error);
                return;
            }

            if (changes != null)
            {

                StartAnimations(changes.InsertedIndices,realm);
            }

        });
        }


}


