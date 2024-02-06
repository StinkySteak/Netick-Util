### Netick 2 Util
Recommended Netick Version: `0.9.10`

### Feature
- PlayerId Converter for `NetworkPlayer` to `InputSourceId`
Currently, on Netick `NetworkPlayer.PlayerId` is not compareable with `NetworkBehaviour.InputSourceId` by default. This extension solve the issue using `GetInputSourcePlayerId()` function 