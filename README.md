![img](https://raw.githubusercontent.com/capashaa/EEToPWGUI/main/img/PixelWalkger_logo.png)

# EEToPWGUI - Pixelwalker.net tool
A gui for EEToPW with all features from EEToPW.  
This tool is for Pixelwalker.net. And nothing else.

This tool is going to try to convert an EELVL to pixelwalker.  
Then upload the information to the pixelwalker.net API through the SDK in the bottom
of this page.  

**Warning:** All blocks that doesn't exist in Pixelwalker is going to be missing from a EELVL file.  
Right now it only support basic worlds.  
Minimap colors is maybe going to be supported in the future. 

### Supported advanced blocks
- [x] Invisible Portal, Visible Portal.  
- [x] Coin Doors/gates, Death doors/gates.  
- [x] Orange/Purple switches/doors/gates.   
- [x] Colored spikes will be normal spikes in PW.  
  
Image of the tool:  
![Image](https://raw.githubusercontent.com/capashaa/EEToPWGUI/main/img/form.png)

## How to use the tool

### How to grab AuthToken:
Login into PixelWalker. Click on Developers tools. In Chrome it's F12.  
Refresh PixelWalker website. Look for auth-refresh. Click on it.  
You should find " Authorization:" a really long AuthToken comes after this text.  
Copy this, and paste below the text AuthToken in the interface.  
**Example:**   
![img](https://raw.githubusercontent.com/capashaa/EEToPWGUI/main/img/Authtoken.png)  

### How to grab WorldID
Join your own world where you want to upload the EE world.  
Remember that at the moment you can only upload 100x100 or 200x200 sizes.  
So don't upload a world that is bigger than these.  

Look in your webbrowser for https://pixelwalker.net/world/ID.  
Copy the ID and paste below the text WorldID.

### Load EELVL
Below this text EELVL FileName, you click on the button Import...  
Import the world you want inside your PixelWalker world.  
Remember, the size of the world can't be bigger than 200x200 or 100x100.  

### Let's upload
Click on the button Upload.   
If you want to cancel click on Stop.  

## Credits and Licenses
[Using Marten's PixelWalker SDK](https://github.com/MartenM/PixelPilot)  
[Using EELVL SDK by Luke](https://gitlab.com/LukeM212/EELVL)  
PixelWalker logo and icon made by Zoey.   
