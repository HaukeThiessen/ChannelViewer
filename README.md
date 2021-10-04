# ChannelViewer
Small tool to quickly display individual color channels of the screen. Useful when creating textures or editing vertex colors which contain different information in each channel and you don't have the option to view the channels separately in your software. Max, Maya and Unreal, for example don't support this function for vertex colors.
Also displays the exact color values of the pixel under the mouse cursor in the title bar.

Shortcuts:
1-4 or R, G, B, A: switch between the displayed channels or all channels combined.
Space: Pin/unpin current capture position (otherwise the tool always displays the area around the mouse cursor)
Page Up/Down: switch between zoom factors. Default is 1, but 0.5 and 0.333 are also available.

Performance: Capturing the screen is not solved in the most performant way. If you notice the tool being laggy, decrease the size of the window. You can use the zoom to still get a good overview.

Known issues:
- Only works on the primary screen, multi-monitor setups aren't tested yet.
- ChannelViewer window appears in the captured image, causing annoying feedback artifacts.

