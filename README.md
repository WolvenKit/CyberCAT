# CyberCAT
--------

CyberPunk 2077 Customization Assistant Tool
--------
The goal is to provide a Tool that can decompress and decompress Cyberpunk save files.
**This is mostly a research project for now.**

Ifyou make progress or discover new information or just have quiestions contact me on Discord SirBitesalot#6627 or join us on the CP77 modding Tools Server https://discord.com/invite/Epkq79kd96

Current State
--------
- The Program can decompress a save file.
- The Program can recompress files
- The Program can recompress modified files
- The Format of the uncompressed file is not fully understood yet.
   - https://github.com/Atvaark/W3SavegameEditor could probably be a good starting point as the files seem to similar but not the same. It already provided a starting point for the LZ4 Chunk handling
- Modification can be done using hex editor of your choice
- Dont expect to be able to edit your saves easily until a later point in time.


Usage
--------
**!Backup your saves!**
- Paste file path of file to decompress or drag file onto textbox.
- Hit "Decompress"
- In the "Output" 2 Files will appear({guid}\_metainf.json and {guid}\_decompressed.bin)
- To Recompress Drag the "{guid}\_decompressed.bin" File onto the textbox titled "Decompressed File Path"
- If you changed the name or the paths changed you need to also drag the "{guid}\_metainf.json" if not it gets added automatically
- Hit "Recompress"
- Test if it works ingame

Dependencies
--------
[K4os.Compression.LZ4][0]

[0]:https://github.com/MiloszKrajewski/K4os.Compression.LZ4
