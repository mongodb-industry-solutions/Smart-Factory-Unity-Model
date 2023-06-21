using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine;
using Realms;
using Realms.Sync;
using MongoDB.Bson;
using TMPro;

public class UpdateSensorData : MonoBehaviour
{
    private static App realmApp = App.Create(Constants.Realm.AppId); 
    private User syncUser;
    private Realm realm;
    private Coroutine queryCoroutine;
    public  TextMeshProUGUI SensorText;
    private IQueryable<sensors> documents;
 
    public double Temperature = 22;
    public double Pressure = 1020;
    public double Humidity = 31.7;
    public double AirQuality = 188;
    public string RoomBrigthness = "84.3";

    private async void Start()
    {
        Debug.Log("Stat script running");
        // Authenticate the user
        realmApp = App.Create(Constants.Realm.AppId);
        syncUser = await realmApp.LogInAsync(Credentials.EmailPassword(Constants.Realm.UserName, Constants.Realm.Password));

        // Configure the sync and open the Realm
        var syncConfiguration = new PartitionSyncConfiguration("DTPartition", syncUser);
        realm = await Realm.GetInstanceAsync(syncConfiguration);

        // Retrieve all existing documents
        documents = realm.All<sensors>();

        // Subscribe to collection changes
        documents.SubscribeForNotifications(OnCollectionChanged);

    }

    private void OnCollectionChanged(IRealmCollection<sensors> collection, ChangeSet changes, Exception error)
    {
        if (error != null)
        {
            Debug.LogError("Error occurred: " + error.Message);
            return;
        }

        if (changes != null)
        {
            // Iterate through the inserted documents
            foreach (var insertIndex in changes.InsertedIndices)
            {
                var sensor_doc = collection[insertIndex];
                Debug.Log("New document inserted: " + sensor_doc);
                if(sensor_doc.Topic=="i/bme680")
                {
                    Temperature = sensor_doc.T ?? 22;;
                    Pressure = sensor_doc.P ?? 1080;;
                    Humidity = sensor_doc.H ?? 30;;
                    AirQuality = sensor_doc.Iaq ?? 150;;
                }
                else if(sensor_doc.Topic=="i/ldr"){
                    RoomBrigthness = sensor_doc.Br;
                }
                // Debug.Log(newMessage);
                SensorText.text = $@"Temperature [°C]: {Temperature}
Room Brightness [%]: {RoomBrigthness}
Air Pressure [hPa]: {Pressure}
Humidity [%]: {Humidity}
Air Quality Index [0-500]: {AirQuality}";
                Debug.Log("Running again...");
                // Debug.Log(sensor_doc);
            }
        }
    }

    // private void OnDestroy()
    // {
    //     // Clean up resources
    //     realm?.Dispose();
    // }

//     private System.Collections.IEnumerator QueryCollectionCoroutine()
//     {
//         while (true)
//         {
//             // Query the collection
//             var sensor_doc = realm.All<sensors>().OrderByDescending(item => item.Ts).FirstOrDefault();
            
//             if(sensor_doc.Topic=="i/bme680")
//             {
//                 Temperature = sensor_doc.T ?? 22;;
//                 Pressure = sensor_doc.P ?? 1080;;
//                 Humidity = sensor_doc.H ?? 30;;
//                 AirQuality = sensor_doc.Iaq ?? 150;;
//             }
//             else if(sensor_doc.Topic=="i/ldr"){
//                 RoomBrigthness = sensor_doc.Br;
//             }
//             // Debug.Log(newMessage);
//             SensorText.text = $@"Temperature [°C]:    {Temperature}
// Room Brightness [%]:  {RoomBrigthness}
// Air Pressure [hPa]:   {Pressure}
// Humidity [%]:         {Humidity}
// Air Quality Index [0-500]:    {AirQuality}";
//             Debug.Log("Running again...");
//             Debug.Log(sensor_doc);
//             yield return new WaitForSeconds(3f); // Wait for 3 seconds before querying again
//         }
//     }
}
