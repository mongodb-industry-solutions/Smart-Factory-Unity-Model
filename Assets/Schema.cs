using System;
using System.Collections.Generic;
using Realms;
using MongoDB.Bson;

/*public class neworder : RealmObject
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
}*/

public partial class digital_twin_orders : IRealmObject
{
    [MapTo("_id")]
    [PrimaryKey]
    public ObjectId? Id { get; set; }

    [MapTo("_partition")]
    [Required]
    public string Partition { get; set; }

    [MapTo("color")]
    public string? Color { get; set; }

    [MapTo("firstName")]
    public string? FirstName { get; set; }

    [MapTo("lastName")]
    public string? LastName { get; set; }

    [MapTo("orderStatus")]
    public string? OrderStatus { get; set; }

    [MapTo("ship_from")]
    public string? ShipFrom { get; set; }

    [MapTo("ship_to")]
    public string? ShipTo { get; set; }

    [MapTo("timeStamp")]
    public DateTimeOffset? TimeStamp { get; set; }

    [MapTo("userId")]
    public string? UserId { get; set; }
}


// public class digital_twin_orders : RealmObject
// {
//     [MapTo("_id")]
//     [PrimaryKey]
//     public ObjectId? Id { get; set; }

 

//     [MapTo("color")]
//     public string Color { get; set; }

//     [MapTo("firstName")]
//     public string FirstName { get; set; }

//     [MapTo("lastName")]
//     public string LastName { get; set; }

//     [MapTo("orderStatus")]
//     public string OrderStatus { get; set; }

//     [MapTo("ship_from")]
//     public string ShipFrom { get; set; }

//     [MapTo("ship_to")]
//     public string ShipTo { get; set; }

//     [MapTo("timeStamp")]
//     public DateTimeOffset? TimeStamp { get; set; }

//     [MapTo("userId")]
//     public string UserId { get; set; }
// }


public partial class mqtt : IRealmObject
{
    [MapTo("_id")]
    [PrimaryKey]
    public ObjectId? Id { get; set; }

    [MapTo("_partition")]
    [Required]
    public string Partition { get; set; }

    [MapTo("active")]
    public double? Active { get; set; }

    [MapTo("aq")]
    public double? Aq { get; set; }

    [MapTo("br")]
    public string? Br { get; set; }

    [MapTo("code")]
    public double? Code { get; set; }

    [MapTo("data")]
    public string? Data { get; set; }

    [MapTo("description")]
    public string? Description { get; set; }

    [MapTo("fps")]
    public double? Fps { get; set; }

    [MapTo("gr")]
    public double? Gr { get; set; }

    [MapTo("h")]
    public double? H { get; set; }

    [MapTo("hardwareId")]
    public string? HardwareId { get; set; }

    [MapTo("hardwareModel")]
    public string? HardwareModel { get; set; }

    [MapTo("iaq")]
    public double? Iaq { get; set; }

    [MapTo("id")]
    public string? AlertId { get; set; }

    [MapTo("ldr")]
    public double? Ldr { get; set; }

    [MapTo("message")]
    public string? Message { get; set; }

    [MapTo("on")]
    public bool? On { get; set; }

    [MapTo("p")]
    public double? P { get; set; }

    [MapTo("period")]
    public double? Period { get; set; }

    [MapTo("rh")]
    public double? Rh { get; set; }

    [MapTo("rt")]
    public double? Rt { get; set; }

    [MapTo("softwareName")]
    public string? SoftwareName { get; set; }

    [MapTo("softwareVersion")]
    public string? SoftwareVersion { get; set; }

    [MapTo("state")]
    public string? State { get; set; }

    [MapTo("station")]
    public string? Station { get; set; }

    [MapTo("stockItems")]
    public IList<mqtt_stockItems> StockItems { get; }

    [MapTo("t")]
    public double? T { get; set; }

    [MapTo("target")]
    public string? Target { get; set; }

    [MapTo("topic")]
    public string? Topic { get; set; }

    [MapTo("ts")]
    public DateTimeOffset? Ts { get; set; }

    [MapTo("type")]
    public string? Type { get; set; }

    [MapTo("workpiece")]
    public mqtt_workpiece? Workpiece { get; set; }
}



// public class mqtt : RealmObject
// {
//     [MapTo("_id")]
//     [PrimaryKey]
//     public ObjectId? Id { get; set; }

 
//     [MapTo("active")]
//     public double? Active { get; set; }

//     [MapTo("aq")]
//     public double? Aq { get; set; }

//     [MapTo("br")]
//     public string Br { get; set; }

//     [MapTo("code")]
//     public double? Code { get; set; }

//     [MapTo("data")]
//     public string Data { get; set; }

//     [MapTo("description")]
//     public string Description { get; set; }

//     [MapTo("fps")]
//     public double? Fps { get; set; }

//     [MapTo("gr")]
//     public double? Gr { get; set; }

//     [MapTo("h")]
//     public double? H { get; set; }

//     [MapTo("hardwareId")]
//     public string HardwareId { get; set; }

//     [MapTo("hardwareModel")]
//     public string HardwareModel { get; set; }

//     [MapTo("iaq")]
//     public double? Iaq { get; set; }

    

//     [MapTo("ldr")]
//     public double? Ldr { get; set; }

//     [MapTo("message")]
//     public string Message { get; set; }

//     [MapTo("on")]
//     public bool? On { get; set; }

//     [MapTo("p")]
//     public double? P { get; set; }

//     [MapTo("period")]
//     public double? Period { get; set; }

//     [MapTo("rh")]
//     public double? Rh { get; set; }

//     [MapTo("rt")]
//     public double? Rt { get; set; }

//     [MapTo("softwareName")]
//     public string SoftwareName { get; set; }

//     [MapTo("softwareVersion")]
//     public string SoftwareVersion { get; set; }

//     [MapTo("state")]
//     public string State { get; set; }

//     [MapTo("station")]
//     public string Station { get; set; }

//     [MapTo("stockItems")]
//     public IList<mqtt_stockItems> StockItems { get; }

//     [MapTo("t")]
//     public double? T { get; set; }

//     [MapTo("target")]
//     public string Target { get; set; }

//     [MapTo("topic")]
//     public string Topic { get; set; }

//     [MapTo("ts")]
//     public DateTimeOffset? Ts { get; set; }

//     [MapTo("type")]
//     public string Type { get; set; }

//     [MapTo("workpiece")]
//     public mqtt_workpiece Workpiece { get; set; }
// }



public partial class mqtt_stockItems : IEmbeddedObject
{
    [MapTo("location")]
    public string? Location { get; set; }

    [MapTo("workpiece")]
    public mqtt_stockItems_workpiece? Workpiece { get; set; }
}


// public class mqtt_stockItems : EmbeddedObject
// {
//     [MapTo("location")]
//     public string Location { get; set; }

//     [MapTo("workpiece")]
//     public mqtt_stockItems_workpiece Workpiece { get; set; }
// }


public partial class mqtt_stockItems_workpiece : IEmbeddedObject
{
    [MapTo("id")]
    public string? Id { get; set; }

    [MapTo("state")]
    public string? State { get; set; }

    [MapTo("type")]
    public string? Type { get; set; }
}

// public class mqtt_stockItems_workpiece : EmbeddedObject
// {
//     [MapTo("id")]
//     public string Id { get; set; }

//     [MapTo("state")]
//     public string State { get; set; }

//     [MapTo("type")]
//     public string Type { get; set; }
// }



public partial class mqtt_workpiece : IEmbeddedObject
{
    [MapTo("id")]
    public string? Id { get; set; }

    [MapTo("state")]
    public string? State { get; set; }

    [MapTo("type")]
    public string? Type { get; set; }
}

// public class mqtt_workpiece : EmbeddedObject
// {
//     [MapTo("id")]
//     public string Id { get; set; }

//     [MapTo("state")]
//     public string State { get; set; }

//     [MapTo("type")]
//     public string Type { get; set; }
// }



public partial class sagemaker_stock_inference : IRealmObject
{
    [MapTo("_id")]
    [PrimaryKey]
    public ObjectId? Id { get; set; }

    [MapTo("_partition")]
    [Required]
    public string Partition { get; set; }

    [MapTo("is_present")]
    public sagemaker_stock_inference_is_present? IsPresent { get; set; }

    [MapTo("ts")]
    public DateTimeOffset? Ts { get; set; }
}


// public class sagemaker_stock_inference : RealmObject
// {
//     [MapTo("_id")]
//     [PrimaryKey]
//     public ObjectId? Id { get; set; }
//     [MapTo("_partition")]
//     public string Partition { get; set; }
//     [MapTo("is_present")]
//     public sagemaker_stock_inference_is_present? IsPresent { get;  set;}
//     [MapTo("ts")]
//     public DateTimeOffset? Ts { get; set; }
// }



public partial class sagemaker_stock_inference_is_present : IEmbeddedObject
{
    [MapTo("blue")]
    public bool? Blue { get; set; }

    [MapTo("red")]
    public bool? Red { get; set; }

    [MapTo("white")]
    public bool? White { get; set; }
}

public partial class sensors : IRealmObject
{
    [MapTo("_id")]
    [PrimaryKey]
    public ObjectId? Id { get; set; }
    [MapTo("_partition")]
    [Required]
    public string Partition { get; set; }
    [MapTo("aq")]
    public double? Aq { get; set; }
    [MapTo("br")]
    public string? Br { get; set; }
    [MapTo("gr")]
    public double? Gr { get; set; }
    [MapTo("h")]
    public double? H { get; set; }
    [MapTo("iaq")]
    public double? Iaq { get; set; }
    [MapTo("ldr")]
    public double? Ldr { get; set; }
    [MapTo("p")]
    public double? P { get; set; }
    [MapTo("rh")]
    public double? Rh { get; set; }
    [MapTo("rt")]
    public double? Rt { get; set; }
    [MapTo("t")]
    public double? T { get; set; }
    [MapTo("topic")]
    public string? Topic { get; set; }
    [MapTo("ts")]
    public DateTimeOffset? Ts { get; set; }
}



// public class sagemaker_stock_inference_is_present : EmbeddedObject
// {
//     [MapTo("blue")]
//     public bool? Blue { get; set; }
//     [MapTo("red")]
//     public bool? Red { get; set; }
//     [MapTo("white")]
//     public bool? White { get; set; }
// }

//[MapTo("id")]
//    public string Id { get; set; }

/*   [MapTo("_partition")]
    [Required]
    public string Partition { get; set; }
    
    
       [MapTo("_partition")]
    [Required]
    public string Partition { get; set; }

    
    
    
    */