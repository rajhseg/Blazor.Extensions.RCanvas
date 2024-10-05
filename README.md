# Blazor.Extensions.RCanvas
This repository consists of Canvas integration or Canvas Reference in Blazor. we can use the exact methods and properties of canvas in blazor to draw a 2D context.

Run below npm commands in vscode terminal.
1. Select "Blazor.Extensions.RCanvas" Project
2. Type "npm install typescript" in terminal
3. Ctrl+Shift+B in vscode, then select tsconfig.json for build the TS files in this project.
4. Run the Project and see the Canvas is rendered when you click the button.

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

    private async Task CreateCanvas(){
        
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

<br/>

![image](https://github.com/user-attachments/assets/6d4ade14-849a-4d17-926a-8dbd510da687)




<br/>
<br />

