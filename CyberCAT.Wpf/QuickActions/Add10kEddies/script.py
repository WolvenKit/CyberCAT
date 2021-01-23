inventoryNode = saveFile.Nodes.Where(lambda n: n.Name == "inventory").FirstOrDefault();
inventory = inventoryNode.Value;
eddieData = inventory.SubInventories.Where(lambda si: si.InventoryId == 1).FirstOrDefault().Items.Where(lambda i: i.ItemTdbId.Name == "Items.money").FirstOrDefault().Data;
eddieData.Quantity=eddieData.Quantity+10000;