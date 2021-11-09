# ITools
##### A simple IT-Toolkit for you

## What does ITools do?
> ITools is a toolkit made by a systemengineer for systemengineers and enthusiasts.
> 
> The toolkit implements functionality in multiple categories:
> * Hashing and Security
> * Hardware / System Information
> * Windows specific Information 
> 
> The toolkit is provided as is and I do not take any responsibility if you fuck up your system during use (looking at you, secure deletion).

## User "Manual"
> On start of the application you will be greeted by a form with multiple groups mentioned above.
> 
> First off, the Security category:
> * Hashing
>   * Lets you get an MD5 or SHA256 Hash of a file, you can also compare Hashes to a file
> * Secure Deletion
>   * Overwrites a files bytes with zeroes, then deletes it (you can't revert this)
> * Encrypt / Decrypt
>   * Lets you encrypt/decrypt a string with a 16 char long password using AES
> * AES Datastorage
>   * Lets you store sensitive information in an AES encrypted file
> 
> Next we got the Hardware / Information category:
> * Get Adapter Info
>   * Gets Information associated with all your NICs (IP, Mask, DNS, DHCP, Name, Type)
> * Get System Info 
>   * Gets all Data about your windows system in a data-view
> * Get COM Ports
>   * Lists all availiable/active COM Ports
> * Get Open Ports
>   * Uses ```netstat``` to get all open ports on the machine and their respective programs (UDP & TCP) 
> 
> Last but not least we got the Windows category:
> * Get Installed Programs
>   * Attempts to get all Programs installed machine wide from the registry
> * Get Service Status
>   * Gets all Services, their name and status (running is highlighted as green, stopped as red)
> * Get Hyper-V VMs
>   * Gets information about your local VMs on HyperV by using powershell
> * Get Environment Vars
>   * Reads all set environment variables
> Most of these Options have the possibility to export their Output by pressing the [Save Output] button
