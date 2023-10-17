using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Realms;
using Realms.Sync;
using MongoDB.Bson;
using TMPro;


public class Order : MonoBehaviour
{

    private static Realm realm;
    private static App realmApp = App.Create(Constants.Realm.AppId); 
    public static User syncUser;
    private IDisposable listenerToken;
    public  Animator myWhiteAnimator;
    public  Animator myRedAnimator;
    public  Animator myBlueAnimator;
    private Coroutine queryCoroutine;

    public float moveSpeed = 0.3f;
    public double Temperature = 22.3;
    public double Pressure = 1020;
    public double Humidity = 31.7;
    public double AirQuality = 188;
    public string RoomBrigthness = "84.3";
     

    // Start is called before the first frame update
    private async void Start()
    {
        syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
        realm = await GetRealm(syncUser);
        SetMovementListener(realm);
    }

    // Update is called once per frame
    void Update()
    {
        // SetMovementListener(realm);
    }



    public  GameObject BlueButton;
    public  GameObject RedButton;
    public  GameObject WhiteButton;
    public  GameObject StockAlert;
    public  TextMeshProUGUI StockAlertText;
    public  TextMeshProUGUI SensorText;



    public async void OnBlueButtonClick(){
                // Debug.Log(Constants.Realm.flag);
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);

                // var stockInferenceId = new ObjectId("6464c8fe29e99ce415176ba9");
                
                // var stock_inference_doc = realm.Find<sagemaker_stock_inference>(stockInferenceId);
                var stock_inference_doc = realm.All<sagemaker_stock_inference>().ElementAt(0);

                if (stock_inference_doc.IsPresent.Blue == false) 
                {
                    Debug.Log("The Physical factory doesn't have a Blue piece in Stock!");
                    StockAlertText.text = "The blue piece you are requesting is out of stock in the Physical Factory!";
                    StockAlert.SetActive(true);
                    GetComponent<Button>().interactable = true;
                    
                    
                } 
                else 
                {
                    Debug.Log("We have a Blue in stock, starting production!");
                    realm.Write(() =>
                    {
                        realm.Add(new digital_twin_orders()
                        {
                            Id = ObjectId.GenerateNewId(),
                            ShipFrom="North York",
                            ShipTo="Barcelona",
                            Color = "blue",
                            UserId ="DT",
                            FirstName="H",
                            LastName="A",
                            Partition="DTPartition",
                            OrderStatus="Order Submitted",
                            TimeStamp = DateTimeOffset.Now
                        });
                    });

                    // SetMovementListener(realm);
                    myBlueAnimator.SetTrigger("start_blue");
                    Debug.Log("start blue animation");
                    
                }
                
                if (Constants.Realm.flag == false){
                    Constants.Realm.flag = true;
                  //  SetMovementListener(realm);
                }
    }

    public  async void OnRedButtonClick(){
                // Debug.Log(Constants.Realm.flag);
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);
                
                // var stockInferenceId = new ObjectId("6464c8fe29e99ce415176ba9");
                // var stock_inference_doc = realm.Find<sagemaker_stock_inference>(stockInferenceId);
                var stock_inference_doc = realm.All<sagemaker_stock_inference>().ElementAt(0);

                if (stock_inference_doc.IsPresent.Red == false) 
                {
                    Debug.Log("The Physical factory doesn't have a Red piece in Stock!");
                    StockAlertText.text = "The red piece you are requesting is out of stock in the Physical Factory!";
                    StockAlert.SetActive(true);
                    GetComponent<Button>().interactable = true;
                    
                    
                } 
                else 
                {
                    Debug.Log("We have a Red in stock, starting production!");
                    realm.Write(() =>
                    {
                        realm.Add(new digital_twin_orders()
                        {
                            Id = ObjectId.GenerateNewId(),
                            ShipFrom="North York",
                            ShipTo="Barcelona",
                            Color = "red",
                            UserId ="DT",
                            FirstName="H",
                            LastName="A",
                            Partition="DTPartition",
                            OrderStatus="Order Submitted",
                            TimeStamp = DateTimeOffset.Now
                        });
                    });

                    SetMovementListener(realm);
                    // myRedAnimator.SetTrigger("start_red");
                    Debug.Log("start red animation");
                }

                if (Constants.Realm.flag == false){
                    Constants.Realm.flag = true;
                   // SetMovementListener(realm);
                }
    }

        public  async void OnWhiteButtonClick(){

                // Debug.Log(Constants.Realm.flag);
                syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));
                realm = await GetRealm(syncUser);

                //// Change the .find to get all documents in the collection and iterate to get the first one
                // var stockInferenceId = new ObjectId("6464c8fe29e99ce415176ba9"); 
                // var stock_inference_doc = realm.Find<sagemaker_stock_inference>(stockInferenceId);
                var stock_inference_doc = realm.All<sagemaker_stock_inference>().ElementAt(0);

                Debug.Log(stock_inference_doc);
                Debug.Log(stock_inference_doc.IsPresent);

                if (stock_inference_doc.IsPresent.White == false) 
                {
                    Debug.Log("The Physical factory doesn't have a White piece in Stock!");
                    StockAlertText.text = "The white piece you are requesting is out of stock in the Physical Factory!";
                    StockAlert.SetActive(true);
                    GetComponent<Button>().interactable = true;
                    
                    
                } 
                else 
                {
                    
                    Debug.Log("We have a White in stock, starting production!");
                    realm.Write(() =>
                    {
                        realm.Add(new digital_twin_orders()
                        {
                            Id = ObjectId.GenerateNewId(),
                            ShipFrom="North York",
                            ShipTo="Barcelona",
                            Color = "white",
                            UserId ="DT",
                            FirstName="H",
                            LastName="A",
                            Partition="DTPartition",
                            OrderStatus="Order Submitted",
                            TimeStamp = DateTimeOffset.Now
                        });
                    });

                    SetMovementListener(realm);
                    // myWhiteAnimator.SetTrigger("start_white");
                    Debug.Log("start white animation");
                }

                // SetStockListener(realm);
                

            
                if (Constants.Realm.flag == false){
                    Constants.Realm.flag = true;
                   // SetMovementListener(realm);
                }

    }


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


    private IEnumerator AnimationDelay(Animator myColorAnimator, string AnimatorName)
    {
        yield return new WaitForSeconds(10f);
        myColorAnimator.SetTrigger(AnimatorName);
    }

    private void StartAnimations(int[] insertedIndices, Realm realm)
{
     Debug.Log("inside Start Animations");
     Debug.Log(insertedIndices.Length);
    foreach (var i in insertedIndices)
    {
        var newMessage = realm.All<mqtt>().ElementAt(i);
        // Debug.Log(newMessage.Topic);

        if(newMessage.State=="ORDERED" && newMessage.Type=="WHITE" && newMessage.Topic=="f/i/order"){
            StartCoroutine(AnimationDelay(myWhiteAnimator, "start_white"));
            // myWhiteAnimator.SetTrigger("start_white");
            Debug.Log("start white animation");
        }

        else if (newMessage.State=="ORDERED" && newMessage.Type=="RED" && newMessage.Topic=="f/i/order"){
            StartCoroutine(AnimationDelay(myRedAnimator, "start_red"));
            // myRedAnimator.SetTrigger("start_red");
            Debug.Log("start red animation");
        }

        else if (newMessage.State=="ORDERED" && newMessage.Type=="BLUE" && newMessage.Topic=="f/i/order"){
            StartCoroutine(AnimationDelay(myBlueAnimator, "start_blue"));
            // myBlueAnimator.SetTrigger("start_blue");
            Debug.Log("start blue animation");
        }

     
    }
}

    // private void UpdateSensorData(int[] insertedIndices, Realm realm)
    // {
    // Debug.Log(insertedIndices.Length);
    // foreach (var i in insertedIndices)
    //     {
    //     var newMessage = realm.All<sensors>().ElementAt(i);
    //     if(newMessage.Topic=="i/bme680"){
    //         Temperature = newMessage.T ?? 22;;
    //         Pressure = newMessage.P ?? 1080;;
    //         Humidity = newMessage.H ?? 30;;
    //         AirQuality = newMessage.Iaq ?? 150;;
    //     }
    //     else if(newMessage.Topic=="i/ldr"){
    //         RoomBrigthness = newMessage.Br;
    //     }
    //     // Debug.Log(newMessage);
    //     SensorText.text = $@"Temperature [°C]: {Temperature}
    //                         Room Brightness [%]: {RoomBrigthness}
    //                         Air Pressure [hPa]: {Pressure}
    //                         Humidity [%]: {Humidity}
    //                         Air Quality Index [0-500]: {AirQuality}";

    //     }
    // }

    public void SetMovementListener(Realm realm)
    {
      Debug.Log("Set movement listener");
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
                Debug.Log("Animation set to start");
                StartAnimations(changes.InsertedIndices,realm);
            }

        });
        }

    // public void  SetSensorListener(Realm realm)
    // {
    //   Debug.Log("Set Sensor listener");
    //   listenerToken = realm.All<sensors>()
    //     .SubscribeForNotifications((sender, changes, error) =>
    //     {
    //         if (error != null)
    //         {
    //             Debug.Log("an error occurred while listening for messages :" + error);
    //             return;
    //         }

    //         if (changes != null)
    //         {
    //             Debug.Log("There's new Sensor data");
    //             UpdateSensorData(changes.InsertedIndices,realm);
                
    //         }

    //     });
    // }




}


