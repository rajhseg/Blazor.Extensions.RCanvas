

using System.Runtime.CompilerServices;
using Microsoft.JSInterop;
using System;
using System.Text.Json.Serialization;

namespace WebComponents.Components.Controls.Canvas;

public class DOMMatrix: DOMMatrixReadOnly {   

    public double a { set; get; }
    public double b { set; get; }
    public double c { set; get; }
    public double d { set; get; }
    public double e { set; get; }
    public double f { set; get; }
    public double m11 { set; get; }
    public double m12 { set; get; }
    public double m13 { set; get; }
    public double m14 { set; get; }
    public double m21 { set; get; }
    public double m22 { set; get; }
    public double m23 { set; get; }
    public double m24 { set; get; }
    public double m31 { set; get; }
    public double m32 { set; get; }
    public double m33 { set; get; }
    public double m34 { set; get; }
    public double m41 { set; get; }
    public double m42 { set; get; }
    public double m43 { set; get; }
    public double m44 { set; get; }
    
    public async Task<DOMMatrix> InvertSelfAsync() {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName}});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> MultiplySelfAsync(DOMMatrixInit other = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, other }});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> PreMultiplySelfAsync(DOMMatrixInit other = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, other}});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> RotateAxisAngleSelfAsync(double? x = null, double? y = null, double? z = null, double? angle = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, x, y, z, angle }});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> RotateFromVectorSelfAsync(double? x = null, double? y = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, x, y }});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> RotateSelfAsync(double? rotX = null, double? rotY = null, double? rotZ = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, rotX, rotY, rotZ }});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> Scale3dSelfAsync(double? scale = null, double? originX = null, double? originY = null, 
        double? originZ = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, scale, originX, originY, originZ }});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> ScaleSelfAsync(double? scaleX = null, double? scaleY = null, double? scaleZ = null, 
        double? originX = null, double? originY = null, double? originZ = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, scaleX, scaleY, scaleZ, originX, originY, originZ }});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> SetMatrixValueAsync(string transformList) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, transformList}});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> SkewXSelfAsync(double? sx = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, sx }});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> SkewYSelfAsync(double? sy = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, sy }});
        value.Runtime = this.Runtime;
        return value;
    }

    public async Task<DOMMatrix> TranslateSelfAsync(double? tx = null, double? ty = null, double? tz = null) {
        string functionName  = GetJsFunctionName();
        var value = await this.Runtime.InvokeAsync<DOMMatrix>("DispatchOperationReturn", 
                new {prop = new dynamic[] { RsubId, functionName, tx, ty, tz }});
        value.Runtime = this.Runtime;
        return value;
    }

}