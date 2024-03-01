### Netick 2 Util
Recommended Netick Version: `0.9.10`

### ⚠ Version Incompatibility ⚠
If your Netick Version is `0.10.13` or above, Do not use this plugin for Converting the Player Id, this issue has been fixed

### Feature
- PlayerId Converter for `NetworkPlayer` to `InputSourceId`
Currently, on Netick `NetworkPlayer.PlayerId` is not compareable with `NetworkBehaviour.InputSourceId` by default. This extension solve the issue using `GetInputSourcePlayerId()` function 
