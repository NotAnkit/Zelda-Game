# Zelda-Game

This Repository is for Team Alpha Won in CSE 3902 recreating the first dungen from the orginal Legend of Zelda Game. This project will take four sprints to complete to add all the functionallity. 

## V1

#### Controls

Controls | Function
| :--- | :---:
Arrow Keys  | to move Link around the screen.
  A | to for Link to use the sword. 
  B | to use Items
  Q | to quit
  R | to Reset
  
#### Bugs
  The projet has a few bugs right now. One bug is that player and enemy projectiles can go through the border and go through blocks. Another bug is that enemy projectiles do not interact with the player. Another bug currently is that enemy when it hits a player and there is a block it gets teleported around. This is to try and ensure that player does not phase through the walls. Another bug is that the enemies are one hit and dies instantly. Another bug is that bomb kills enemies when the bomb hasnt exploded. With the door there are a few bugs. One of this is that only the left and the right work and they iterate to the next door in the sequence, but not in the map. The second bug is that any type of door allows passage including locked and such, it can be fixed easily. The final bug is that when link goes through it sometimes it chnages multiple as link is so close to the next door.

#### Code Metrics

   - Week 1: 251 Stylistic Recomendations
   - Week 2: 53 Stylistic Recomendations
   - Week 3: 22 Stylistic Recomendations
   
  IDE0045: Convert to conditional expression
  dotnet_style_prefer_conditional_expression_over_assignment = false
  - Suppressed because doing math in if statement reduces complexity

  IDE0044: Add readonly modifier
  dotnet_style_readonly_field = false
  - Supressed because unknown whether need to be able to modify in the future

  IDE0090: Use 'new(...)'
  dotnet_diagnostic.IDE0090.severity = none
  - Supressed because breaks code if not intialized correctly

  IDE0011: Add braces
  dotnet_diagnostic.IDE0011.severity = none
  - Suppressed because doing math in if statement reduces complexity and clean code

  IDE0058: Expression value is never used
  dotnet_diagnostic.IDE0058.severity = none
  - Suppressed because not usable yet

  IDE0028: Simplify collection initialization
  dotnet_diagnostic.IDE0028.severity = none
  - Supressed because breaks code if not intialized correctly

  IDE0055: Fix formatting
  dotnet_diagnostic.IDE0055.severity = none
  - Suppressed because doing math in if statement reduces complexity

  IDE0052: Remove unread private members
  dotnet_diagnostic.IDE0052.severity = none
   - Supressed because unknown whether need to be able to modify in the future
