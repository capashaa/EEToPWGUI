# EEToPWGUI
A gui for EEToPW with all features from EEToPW.

![Image](https://raw.githubusercontent.com/capashaa/EEToPWGUI/main/img/form.png)

## How to use the tool

### How to grab AuthToken:
Login into PixelWalker. Click on Developers tools. In Chrome it's F12.  
Refresh PixelWalker website. Look for auth-refresh. Click on it.  
You should find " Authorization:" a really long AuthToken comes after this text.  
Copy this, and paste below the text AuthToken in the interface.  

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

## SDK's used in this project
[Using Marten's PixelWalker SDK](https://github.com/MartenM/PixelPilot)  
[Using EELVL SDK by Luke](https://gitlab.com/LukeM212/EELVL)  
