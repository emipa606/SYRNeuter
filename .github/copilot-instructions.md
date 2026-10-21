# GitHub Copilot Instructions for [SYR] Neuter (Continued)

## Mod Overview and Purpose

The [SYR] Neuter (Continued) mod is an updated version of the original mod by Syrchalis that enhances animal management in RimWorld by providing players with additional options for controlling animal reproduction. 

### Key Features and Systems

1. **Neutering Surgery**: 
   - Adds a new surgery option to permanently neuter animals, preventing them from reproducing. This procedure is available at no cost.
   
2. **Reversible Infertility Surgery**:
   - Introduces a surgery to make animals reversibly infertile using one unit of medicine. This surgery is reversible, allowing for flexibility in breeding decisions.

3. **Pregnancy Abortion Surgery**:
   - Offers a surgical bill to abort an animal's pregnancy. This is possible even during early stages of pregnancy. Players can manually inspect each female to identify and terminate pregnancies.

4. **Savegame Compatibility**:
   - The mod is safe to add or remove from savegames without causing issues.

5. **Incompatibilities**:
   - The mod is currently free of incompatibilities.

### Coding Patterns and Conventions

- **C# Syntax and Structure**:
  - The mod follows standard C# coding conventions with clear type and member definitions.
  - Functions such as `ApplyOnPawn`, `AvailableOnNow`, and `GetPartsToApplyOn` are used within `Recipe_Neuter.cs` to manage recipe-specific logic.

- **Project Organization**:
  - C# and XML files are organized by functionality, with separate directories for Harmony patches and XML definitions.
  - Consistent naming conventions are used across file names and class members for clarity.

### XML Integration

- The mod uses XML files to define game elements like surgeries (`Recipe_Neuter.xml`).
- **HediffDef** and **RecipeDef** are primary XML definitions used for modifying health conditions and crafting recipes linked to surgeries.
- Important XML locations include:
  - `Defs\Recipe_Neuter.xml`: Contains definitions for the neutering and infertility surgeries.
  - `Source\About.xml`: Declares mod dependencies such as brrainz.harmony.

### Harmony Patching

- Harmony is utilized to modify and extend RimWorld's existing code without altering the base game files directly.
- Example Harmony patches:
  - `PatchInitiator.cs`: Initializes all necessary patches for mod functionality.
  - `PawnUtility_FertileMateTarget.cs` and `PawnUtility_Mated.cs`: Apply specific postfix and prefix patches to influence mating behaviors.

### Suggestions for Copilot

- **Predictive Code Suggestions**:
  - When working on surgery-related functionality, focus on extending existing method logic in `Recipe_Neuter.cs` such as `ApplyOnPawn` for new surgery mechanics.
  - For Harmony patches, Copilot can assist in suggesting suitable Prefix or Postfix methods for patching methods in RimWorld core classes.
  
- **XML Definitions**:
  - Copilot can auto-generate XML definitions following the pattern observed in existing XML files, ensuring Defs are consistent and complete.

- **Refactoring and Optimization**:
  - Suggest refactoring opportunities to simplify code logic in C#, especially for repetitive operations across different surgeries.

By following these instructions, using Copilot can enhance and expedite the development and maintenance of the [SYR] Neuter (Continued) mod for RimWorld.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

