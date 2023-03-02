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
    public  Animator myWhiteAnimator;


    public async void OnBlueButtonClick(){
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);
                realm.Write(() =>
                {
                    realm.Add(new neworder()
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
    }

    public  async void OnRedButtonClick(){
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);
                realm.Write(() =>
                {
                    realm.Add(new neworder()
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
    }

        public  async void OnWhiteButtonClick(){
        //realm = GetRealm();
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);
                realm.Write(() =>
                {
                    realm.Add(new neworder()
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

                //animator code
                myWhiteAnimator.SetTrigger("start_white");

    }

    // GetRealm() returns a realm instance
   /* private static Realm GetRealm()
    {
        return Realm.GetInstance();

    }
*/

    private static async Task<Realm> GetRealm(User loggedInUser)
    {
       var syncConfiguration = new PartitionSyncConfiguration("DT", loggedInUser);
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


}


