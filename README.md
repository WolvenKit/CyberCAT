# CyberCAT
CyberPunk 2077 Custimazation Assistant Tool
--------
The Tool can be used to uncompress a save file and to compress an uncompressed file.
Currently I was not able to make modifications to an uncompressed file and load the recompressed file in game.
This probably means that I dont understand the uncompressed Format.
If you have questions or ideas feel free to contact me on Discord SirBitesalot#6627

https://github.com/Atvaark/W3SavegameEditor was used as inspiration for LZ4 Handling of the SaveFile.

Current State
--------
The Program can uncompress a save file.
It can Compress the uncompressed data again.
The compressed File can be loaded in game.
Modifications where currently unssuccesful
If this is due to wrong compression or wrong modifications is unknown.

Usage
--------
- Backup your saves!!
- Paste the path to one of your "sav.dat" files into the checkbox.
- Press "Uncompress"
- In the folder the Program was started from a file with naming scheme like "uncompressed_{guid}.bin" will appear. This is the uncompressed save data.
- Now you can analyze the file and make changes.
- To compress press "Recompress" (WARNING! currently you need to keep the program running between decompressing and compressing because metadata is kept in RAM only!)
- Copy the file back into your save game folder.
- Check if the file can be loaded.
- Optionally:
- If you made changes and the file loaded successfully message me on discord the we can figure out the format of the uncompressed data.

Dependencies
--------
[K4os.Compression.LZ4][0]

[0]:https://github.com/MiloszKrajewski/K4os.Compression.LZ4
