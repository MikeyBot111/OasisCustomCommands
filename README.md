# OasisCustomCommands

> **⚠️ Archived – old project, no longer maintained.**
> Written in 2023 for the **Oasis** Unturned servers. It's kept here for reference only. It may not work with current versions of Unturned or RocketMod.

A RocketMod plugin for **Unturned** that lets server owners create simple text commands (like `/rules`, `/discord` or `/info`) from the plugin config, without writing any code.

## What it does

- Reads a list of `TextCommand` entries from the plugin configuration
- Registers each one as a chat command when the plugin loads
- When a player runs the command, the configured lines are sent to their chat
- Each command has its own name and help text (optional browser URL fields are in the config too)

## Example config

```xml
<TextCommands>
  <TextCommand>
    <Name>rules</Name>
    <Help>Shows the server rules</Help>
    <SendToBrowser>false</SendToBrowser>
    <BrowserUrl></BrowserUrl>
    <Text>
      <Line>#1 No offensive content in the chat, respect other players</Line>
      <Line>#2 No bug using, exploiting or abuse of powers</Line>
    </Text>
  </TextCommand>
</TextCommands>
```

## Tech

- C# / .NET Framework 4.8
- RocketMod (`Rocket.API`, `Rocket.Core`, `Rocket.Unturned`)
- `lib/` holds the reference assemblies needed to build (Unturned, Unity and Rocket DLLs)

## Build

Open `OasisCustomCommands.sln` in Visual Studio and build it. Then copy `OasisCustomCommands.dll` into your server's `Rocket/Plugins` folder.

## Part of the Oasis project

[OasisEssential](https://github.com/MikeyBot111/OasisEssential) · [OasisTeleport](https://github.com/MikeyBot111/OasisTeleport) · [OasisKits](https://github.com/MikeyBot111/OasisKits) · [OasisRanks](https://github.com/MikeyBot111/OasisRanks) · [OasisVault](https://github.com/MikeyBot111/OasisVault) · [OasisDiscord](https://github.com/MikeyBot111/OasisDiscord) · [OasisCustomCommands](https://github.com/MikeyBot111/OasisCustomCommands) · [WebsiteOasis](https://github.com/MikeyBot111/WebsiteOasis) · [oasis-server-discord](https://github.com/MikeyBot111/oasis-server-discord)
