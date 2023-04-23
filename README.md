# Snell-s-Law-Science-Project
ALL FOUR UNITY C# SCRIPTS FOR SCIENCE PROJECT BY AARON:

**ScienceProjectScript:** This is the whole brains and logic of the program. It contains all of the calculations for Snell's Law.

**ChangeToWater:** Essentially just handles the 'water' button so that when you press it, the variable 'material' in class 'ScienceProjectScript' is set to 'water'

**ChangeToGlass:** Does the same as 'ChangeToWater' class but instead changes string variable 'materal' to 'glass', NOT 'water'

**quitGame:** Handles the quit button. When you press it, it runs the code 'Application.Quit();' which stops the program from running. (PS: I realise I used the incorrect style while naming this script, I should've capitalised it)



One thing that would've made the code better is making it so when you spawn 'backgroundGlass' it would delete the previous 'backgroundWater', and vice versa. This would've made the code more lag efficient.  
