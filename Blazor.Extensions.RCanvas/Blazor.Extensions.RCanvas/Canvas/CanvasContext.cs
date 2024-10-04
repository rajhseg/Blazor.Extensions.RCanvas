using System;

namespace WebComponents.Components.Controls.Canvas;


public class CanvasContext : CanvasContextFunctions, ICanvasContext {
    public CanvasContext() {

    }
}



public interface ICanvasContext : ICanvasContextProperties, ICanvasContextFunctions {

}

