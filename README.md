# CyberCAT
--------

CyberPunk 2077 Custimazation Assistant Tool
--------
The goal is to provide a Tool that can uncompress and recompress Cyberpunk save files.
If you have questions or ideas feel free to contact me on Discord SirBitesalot#6627

https://github.com/Atvaark/W3SavegameEditor was used as inspiration for LZ4 Handling of the SaveFile.

Current State
--------
The Program can uncompress a save file.
Some Files can be recompressed generating a files that is the same as the original
Some files are changed by the compression in a way that makes them invalid (cant be loaded ingame)
Modifying before recompression always results in an invalid file.
This Probably means there is a checksum or something else that prevents the game from loading recompressed saves.

Usage
--------
Dont

Dependencies
--------
[K4os.Compression.LZ4][0]

[0]:https://github.com/MiloszKrajewski/K4os.Compression.LZ4
