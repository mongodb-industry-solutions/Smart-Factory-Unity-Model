using System;
using System.Collections.Generic;
using Realms;
using MongoDB.Bson;

public class neworder : RealmObject
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
    [Required]
    public string UserId { get; set; }
}
