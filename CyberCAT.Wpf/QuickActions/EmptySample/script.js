/*
predefined Variable:
lib->HostTypeCollection of the CyberCAT.Core assembly see: https://microsoft.github.io/ClearScript/Reference/html/T_Microsoft_ClearScript_HostTypeCollection.htm
nodes->The "Nodes" Property of the currently loaded SaveFile
host->An instance of "HostFunctions" see: https://microsoft.github.io/ClearScript/Reference/html/T_Microsoft_ClearScript_HostFunctions.htm

Accesible types:
- All types of CyberCAT.Core
- Enumerable
- EnumerableExtensions->Gives access to Enumerable.where to use like c# linq expressions
	For Example to get the Inventory Node use it like:
	var inventoryNode = nodes.where(n=> n.Name == "inventory").FirstOrDefault();
	
Some objects need to be cast to their correct type
This can be achieved using the host.cast(lib.<insertClassNameWithFullNamespace>, objectToCast)
*/

//Add your code