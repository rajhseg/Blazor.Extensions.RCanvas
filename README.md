# Blazor.Extensions.RCanvas
This repo is consists of Canvas integration in Blazor

Run below npm commands in vscode terminal.
1. select Blazor.Extensions.RCanvas Project
2. type npm install typescript in terminal
3. ctrl+shift+b in vscode, then select tsconfig.json for build the TS files in this project.
4. Run the Project and see the Canvas is rendered when you click the button.

### How to use
1. Add the Below script tag in head section.
      <script src="./_content/Blazor.Extensions.RCanvas/Canvas/RCanvas.razor.js" type="text\javascript"></script>

2. Add the below namespaces in the component or page.
       @using Blazor.Extensions.RCanvas.Canvas;
       @using WebComponents.Components.Controls.Canvas

3. Use the Canvas by add the below html tag.
       <RCanvas @ref="Canv" Width="400" Height="400"></RCanvas>
       <button @onclick="CreateCanvas">Create Canvas</button>

4. In CS code how to access, see the below snippet.

        
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

