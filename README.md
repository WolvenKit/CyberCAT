# CyberCAT
CyberPunk 2077 Custimazation Assistant Tool
--------
Currently a Savegame can be decompressed and compressed so that the tool itself can decompress it again. Sadly the resulting file differs slightly from the original Savegame even if no changes where made. If this is the reason why the game cant load the file is unclear. It could very well be normal behaviour of the compression and the game is using some kind of checksum in the header section that I currently dont understand fully.

Feel free to copy the code and try if you can come up with a solution.
If you have questions or ideas feel free to contact me on Discord SirBitesalot#6627

https://github.com/Atvaark/W3SavegameEditor was used as inspiration for LZ4 Handling of the SaveFile.
Dependencies
--------
[K4os.Compression.LZ4][0]

[0]:https://github.com/MiloszKrajewski/K4os.Compression.LZ4
