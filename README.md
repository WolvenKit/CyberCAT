# CyberCAT
CyberPunk 2077 Custimazation Assistant Tool
--------
Currently the game sees the file as invalid even though the Tool itself can read its own files the same way it reads the original save.

Feel free to copy the code and try if you can come up with a solution.
If you have questions or ideas feel free to contact me on Discord SirBitesalot#6627

https://github.com/Atvaark/W3SavegameEditor was used as inspiration for LZ4 Handling of the SaveFile.

Current State
--------
The Program can uncompress a save file.
It can Compress the uncompressed data again.
The new file differs slightly. This is as far as i can see because some chunks get compressed differently.
The Tool itself can uncompress a file that it compressed without problem.
The Game sees the file as invalid.

Dependencies
--------
[K4os.Compression.LZ4][0]

[0]:https://github.com/MiloszKrajewski/K4os.Compression.LZ4
