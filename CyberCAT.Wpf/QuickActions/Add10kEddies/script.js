var inventoryNode = nodes.where(n=> n.Name == "inventory").FirstOrDefault();
var inventory = inventoryNode.Value;
var eddies = inventory.SubInventories.where(si => si.InventoryId == 1).FirstOrDefault().Items.where(i => i.ItemTdbId.Name == "Items.money").FirstOrDefault();
var sum = nodes.sum(n=>n.Id)
var typedEddieData = host.cast(lib.CyberCAT.Core.Classes.NodeRepresentations.ItemData.SimpleItemData, eddies.Data);
typedEddieData.Quantity += 10000;
