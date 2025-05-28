# Blazor.Extensions.RCanvas
This repository consists of Canvas integration or Canvas Reference in Blazor. we can use the exact methods and properties of canvas javascript in blazor to draw a 2D context.

Run below npm commands in vscode terminal if you use code directly by download this project.
1. Select "Blazor.Extensions.RCanvas" Project from download the above project.
   we have two projects in the solution, one is example project, second one is canvas library, so select the second one
2. you may found this path after download, if you download in F drive. "F:\Blazor.Extensions.RCanvas\Blazor.Extensions.RCanvas\Blazor.Extensions.RCanvas>"
3. Type "npm install -g typescript" in terminal
4. Ctrl+Shift+B in vscode, then select tsconfig.json for build the TS files in this project.
5. Run the Project and see the Canvas is rendered when you click the button.

Run below command if you use package 
1. dotnet add package Blazor.Extensions.RCanvas --version 10.0.0
2. OnAfterRenderAsync should get called, so then only canvas will render
   
### How to use
1. Add the Below script tag in head section.
   <br/>
      <script src="./_content/Blazor.Extensions.RCanvas/Canvas/RCanvas.razor.js" type="text\javascript"></script>      

3. Add the below namespaces in the component or page. <br/>
       @using Blazor.Extensions.RCanvas.Canvas; <br/>
       @using WebComponents.Components.Controls.Canvas

4. Use the Canvas by add the below html tag. <br/>
       <RCanvas @ref="Canv" Width="400" Height="400"> &lt;/RCanvas> <br/>       

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
}

<br/>

![image](https://github.com/user-attachments/assets/6d4ade14-849a-4d17-926a-8dbd510da687)




<br/>
<br />

