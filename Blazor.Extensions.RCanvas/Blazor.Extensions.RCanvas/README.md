# Blazor.Extensions.RCanvas
This repository consists of Canvas integration or Canvas Reference in Blazor. we can use the exact methods and properties of canvas javascript in blazor to draw a 2D context.

Run below npm commands in vscode terminal.
1. install nuget package "Blazor.Extensions.RCanvas" to the Project



### How to use
1. Add the Below script tag in head section.

      <script src="_content/Blazor.Extensions.RCanvas/Canvas/RCanvas.razor.js" type="text\javascript">        
      </script>      

3. Add the below namespaces in the component or page. 

       @using Blazor.Extensions.RCanvas.Canvas;
       @using WebComponents.Components.Controls.Canvas

4. Use the Canvas by add the below html tag.

       <RCanvas @ref="Canv" Width="400" Height="400"> &lt;/RCanvas>      

5. In CS code how to access, see the below snippet.

        
@code {

    private RCanvas Canv {get; set;}

    private CanvasContext canvasContext;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {    
        try {
            if(firstRender) {
                this.Canv.ScriptLoaded = async () =>
                {
                    await CreateCanvas();
                };               
            }
        }
        catch(Exception ex){
            string m = ex.Message;
        }

        await base.OnAfterRenderAsync(firstRender);
    }


    private async Task CreateCanvas(){

        if (this.Canv.IsScriptLoaded)
        {        
           canvasContext = await this.Canv.CreateContext2DAsync();
   
           if(canvasContext!=null)
           {
               await canvasContext.BeginPathAsync();
               canvasContext.LineWidth = 2;
               var met = await canvasContext.MeasureTextAsync("Sample Title");
               await canvasContext.MoveToAsync(0, 0);
               await canvasContext.LineToAsync(300, 170);
               await canvasContext.StrokeAsync();
               await canvasContext.ClosePathAsync();
   
               await canvasContext.BeginPathAsync();
               var res = await canvasContext.CreateLinearGradientAsync(0,0,270, 0);
               await res.AddColorStopAsync(0, "blue");
               await res.AddColorStopAsync(0.7, "yellow");
               await res.AddColorStopAsync(1, "red");
               canvasContext.FillStyle = res.RsubId;
               await canvasContext.FillRectAsync(20,20,150,100);
               await canvasContext.ClosePathAsync();
           }
        }
    }


