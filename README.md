# CyberCAT
--------

CyberPunk 2077 Customization Assistant Tool
--------
Work in Progress Save Game Editor

**This is still in early development.**

If you make progress or discover new information or just have quiestions contact me on Discord SirBitesalot#6627 or join us on the CP77 modding Tools Server https://discord.com/invite/Epkq79kd96

Current State
--------
- The Program can decompress a save file.
- The Program can recompress files
- The Program can edit save files
- The Program can save edited files
- Some sections of the save file are parsed so they can be easier understood.


Usage
--------
**!Backup your saves!**

Compression Tab:
- Paste file path of file to decompress or drag file onto textbox.
- Hit "Decompress"
- In the "Output" 2 Files will appear({guid}\_metainf.json and {guid}\_decompressed.bin)
- To Recompress Drag the "{guid}\_decompressed.bin" File onto the textbox titled "Decompressed File Path"
- If you changed the name or the paths changed you need to also drag the "{guid}\_metainf.json" if not it gets added automatically
- Hit "Recompress"
- Copy over "{guid}\_recompressed.bin" into save game folde and rename to sav.dat (did I mention backing up original saves ;))
- Test if it works ingame

Editor:
- Click Load and select a savegame
- Select Nodes in TreeView
- Make changes
- Click save
- Load file ingame and check if it works

Dependencies
--------
[K4os.Compression.LZ4][0]

[0]:https://github.com/MiloszKrajewski/K4os.Compression.LZ4
