# Android Debloat
## Phone setup
You need to keep note of the unique application package names of the bloatware apps. You can also make use of my bloatware list which was compiled by me for Samsung Galaxy S21 FE.
* You can make use of one of many apps on the Playstore such as [App Inspector](https://play.google.com/store/apps/details?id=com.ubqsoft.sec01&hl=en_IN&gl=US) or [Package Name Viewer 2.0](https://play.google.com/store/apps/details?id=com.csdroid.pkg&hl=en_IN&gl=US) to view the package names of the apps on your phone.  
* Keep note of the packages you wish to uninstall in a .csv file.  
Ensure it's named ``` bloat_list.csv``` and follows the format:  
	```shell
	App_Name, com.package.name
	App_Name2, com.package.name2
	```
* Crosscheck with bloatware lists online (xda forum, etc)
* Connect your phone to a laptop via a USB cable; enable file sharing on your phone; and transfer the list of unwanted apps from the previous steps to your PC. 
    * If you used Package Name Viewer 2.0 then you can find the csv file in  
    Phone Name\Internal storage\Android\data\com.csdroid.pkg\files\pkg\

* Enable USB debugging  
	* Enable Developer Options
		* Settings > About Phone > Software Information > Tap Build number 7 times  
        if prompted for password, provide it
	* Developer Options >
		* Stay Awake while charging
		* Enable USB Debugging  
## PC Setup
* Download Android SDK Platform tools to your Windows PC  
https://developer.android.com/studio/releases/platform-tools#downloads  
* Extract to a suitable location
* Copy the powershell script and bloat_list.csv to the android sdk folder.
* Open a terminal in that location  
* Run  
  ```shell
  ./adb.exe devices  
  ```
when prompted on phone, click yes for remote debugging.  
* Run the powershell script to uninstall all the bloatware at once.  
  ```shell
  ./uninstall_script.ps1
  ```
## References
Guide:  
https://www.xda-developers.com/uninstall-carrier-oem-bloatware-without-root-access/  
Samsung Bloatware forum posts:  
https://forum.xda-developers.com/t/debload-bloatware-s21-s21-s21ultra-or-any-flagship-samsung-huawei-oneplus-phones.4238473/  
https://forum.xda-developers.com/t/help-galaxy-s21-ultra-bloatware-debloat.4237379/  
https://forum.xda-developers.com/t/galaxy-s10-s10-debloat-bloatware-removal-list.3912073/  