using System.Runtime.CompilerServices;
using Microsoft.JSInterop;
using System;
using System.Text.Json.Serialization;


namespace WebComponents.Components.Controls.Canvas;

public class DOMPoint : DOMPointReadOnly {
    
    public int? w { get; set; }
    
    public int? x { get; set; }
    
    public int? y { get; set; }
    
    public int? z { get; set; }
}

public class DOMPointReadOnly {

     [JsonPropertyName("rsubId")]
    public string RsubId 
    {
        get; set;
    }

    public IJSObjectReference Runtime
    {
        get; set;
    }
    
    public int? w { get; set; }
    
    public int?  x{ get; set; }
    
    public int?  y{ get; set; }
    
    public int?  z{ get; set; }
    
    public async Task<DOMPoint> MatrixTransformAsync(DOMMatrixInit matrix) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMPoint>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, matrix }});
        value.Runtime = this.Runtime;
        return value;
    }
    
    public async Task<object> ToJSONAsync() {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<object>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName}});        
        return value;
    }
    
    protected string GetJsFunctionName([CallerMemberName] string method = ""){
        return char.ToLowerInvariant(method[0]).ToString() + method.Substring(1, method.Length - 6);
    }
}