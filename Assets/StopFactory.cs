using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Realms;
using Realms.Sync;
using System.Linq;

public class StopFactory : MonoBehaviour
{
    private static Realm realm;
    private static App realmApp = App.Create("unityapp-wdmdj"); 
    public GameObject StopButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void OnStopButtonClick(){
        realm = GetRealm();

        if (StopButton != null)
            {
             var allCommands =  realm.All<command>();
             Debug.Log("Commands count is: " + allCommands.AsQueryable().Count().ToString());

            // foreach (var command in allCommands)
              //   {
                //       Debug.Log(command.Value);
                 //}
         
            }
    }


    // GetRealm() returns a realm instance
    private static Realm GetRealm()
    {
        return Realm.GetInstance();

    }

}

