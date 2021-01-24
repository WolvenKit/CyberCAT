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

// Get the inventory node
var inventoryNode = nodes.where(n => n.Name == "inventory").FirstOrDefault();

//Get the "Value" property of the node (This contains the parsed data)
var inventory = inventoryNode.Value;

//Get the subinventory where Id is "1" and get the item with name "Items.money"
var eddies = inventory.SubInventories.where(si => si.InventoryId == 1).FirstOrDefault().Items.where(i => i.ItemTdbId.Name == "Items.money").FirstOrDefault();

//The "Data" property needs to be cast to the correct type. In this case "CyberCAT.Core.Classes.NodeRepresentations.ItemData.SimpleItemData"
var typedEddieData = host.cast(lib.CyberCAT.Core.Classes.NodeRepresentations.ItemData.SimpleItemData, eddies.Data);

//increment "Quantity" property by 10.000
typedEddieData.Quantity += 10000;
