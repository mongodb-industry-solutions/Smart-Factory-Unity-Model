using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Realms;
using MongoDB.Bson;





public class command : RealmObject
{
    [MapTo("_id")]
    [PrimaryKey]
    public ObjectId? Id { get; set; }

    [MapTo("command")]
    public string Command { get; set; }

    [MapTo("ts")]
    public DateTimeOffset? Ts { get; set; }
}


public class order : RealmObject
{
    [MapTo("_id")]
    [PrimaryKey]
    public ObjectId? Id { get; set; }

    [MapTo("color")]
    public string Color { get; set; }

    [MapTo("firstName")]
    public string FirstName { get; set; }

    [MapTo("lastName")]
    public string LastName { get; set; }

    [MapTo("orderStatus")]
    public string OrderStatus { get; set; }

    [MapTo("ship_from")]
    public string ShipFrom { get; set; }

    [MapTo("ship_to")]
    public string ShipTo { get; set; }

    [MapTo("timeStamp")]
    public DateTimeOffset? TimeStamp { get; set; }

    [MapTo("userId")]
    public string UserId { get; set; }
}
