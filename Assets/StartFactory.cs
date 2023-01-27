using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Realms;
using Realms.Sync;





public class StartFactory : MonoBehaviour
{
    private static Realm realm;
    private static App realmApp = App.Create("unityapp-wdmdj"); 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject StartButton;
    

    public void OnStartButtonClick(){
        realm = GetRealm();

        if (StartButton != null)
            {
                realm.Write(() =>
                {
                    realm.Add(new Command()
                    {
                        Value = 1
                    });
                });
            }
    }


    // GetRealm() returns a realm instance
    private static Realm GetRealm()
    {
        return Realm.GetInstance();

    }


}


