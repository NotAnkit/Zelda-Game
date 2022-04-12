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
  The project has a few bugs right now. One bug is in room 15 you can force move the pushable block from faraway. Honestly might even be a feature. Next bug is with enemies taking damage the sword weapons are not supposed to one hit kill but it does for some reason. The Sound plays multiple times which can crash the game. Link can get hit through doors, which is a result of it not freezing fast enough. Another bug with room 15 is the stairs and how you can ascess them but not steping ont he right block, something with they way the collision is analyzed. Another bug currently is that the selector does not select the new items and it is not lined up fully.

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

  IDE0032: Use auto property
  dotnet_diagnostic.IDE0032.severity = none
  - Auto proprerty does not set them up correctly and this needs to be suppresed

  IDE0078: Use pattern matching
  dotnet_diagnostic.IDE0078.severity = none
  - Pattern Matching is not allowed in the current version of C# we are using 

  IDE0063: Use simple 'using' statement
  csharp_prefer_simple_using_statement = false
  - This is part is generated monogame and thus we can not modify it

  IDE0008: Use explicit type
  dotnet_diagnostic.IDE0008.severity = none
  - Can not do this because this is part of the monogame

  IDE0038: Use pattern matching
  csharp_style_pattern_matching_over_is_with_cast_check = false
  - Pattern matching is not allowed for current version C#

