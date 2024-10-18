# TowerDefenseTemplate

Korte omschrijving van mijn towerdefense game

Ik maak een towerdefense game, 
waarbij de towers honden zijn en de player een stickman poppetje. 
Het doel van het spel is om de stickman poppetjes tegen te houden, 
zodat ze niet aan het einde komen waardoor ze de hond aan het einde knuffelen. 
Jij bestuur de towers van honden en moet de stickman poppetjes tegen houden.

Hoe werkt mijn game:
Er komt een enemy in het scherm, door linkermuisknop in te drukken kan je schieten. 
De hond aan de linkerkant is je tower, daar schiet je vanuit. 
Je moet op de enemy schieten zodat hij niet aan het einde komt.
Ook kan je als je linkmuisknop vast hou op je tower, je tower verslepen.
Als de enemy verslagen is dan heb je gewonnen.
Maar als de enemy bij de rechter hondje komt dan heb je verloren.

![Main Menu](/Mainmenu%20screenshot.png)

![Gameplay](/Game%20screenshot.png)


## Product 1: "DRY SRP Scripts op GitHub"

Plaats hier minimaal 1 link naar scripts die voldoen aan de eisen van **"Don't Repeat Yourself (DRY)"** en **"Single Responsibility Principle"**.
Omschrijf hier waarom jij denkt dat je in die scripts aan deze eisen voldoet.

Bijvoorbeeld:

*"In dit script heb ik een array gebruikt voor al mijn vijanden die in de nieuwe wave worden gespawnd. Hierdoor heb ik mijzelf niet hoeven herhalen **(DRY)** in de code omdat ik met 1 regel alle enemies kan plaatsen via en for each loop.
[link naar script](/MyTowerDefenseGame/Assets/Scripts/JustAScript.cs)"*

## Product 2: "Projectmappen op GitHub"

Je commit de mappenstructuur van je unity project op github en verwijst vanuit je readme naar de root map van je project. Met een netjes en goed gestructureerde mappenstructuur en benamingen van files toon je aan dat je dit leerdoel beheerst. 

Dit is de [ROOT](/Tower%20Defense/) folder van mijn unity project.

![Mappenstructuur](/MapStructuur%20screenshot.png)

Hierboven zie je een afbeelding van mijn mappenstructuur.
De structuur die aanneem is alle mappen beginnen met een hoofdletter.
Als er 2 woorden zijn zit er een spatie tussen en begint de volgende woord ook met hoofdletter.
Verder in de Scripts folder komen folders voor waar de scripts voor zijn.
Zoals: Enemy scripts komen in de Enemy folder zoals het lopen van de enemy dat hij van waypoint naar waypoint gaat.
Enviorment is wat er op de map gebeurt zoals op de map zitten waypoints die de enemy volgt, 
Tower zijn alle scrips die met de towers temaken heeft zoals het schieten van de bullet in dit geval.
Maar als er bijvoorbeeld meerdere towers waren dan hadden er nog folders in tower gekomen waarbij de naam van de tower de naam is van de map bijvoorbeeld poep gooiende tower (poepgooier).

## Product 3: Build op Github

Je maakt in Unity een stabiele “build” van je game waarbij bugs en logs eerst zijn verwijderd. Deze buildfiles upload je in je repository onder releases.  Bij eventuele afwijkingen moeten deze worden gedocumenteerd in de release. (Bijv controller nodig of spelen via netwerk etc..) 

[Release Voorbeeld](https://github.com/erwinhenraat/TowerDefenseTemplate/releases)

## Product 4: Game met Sprites(animations) en Textures 

//De build van je game bevat textures, sprites en sprite animations(bijv particles) die op de juiste manier zijn gebruikt en zorgen voor een goede afwerking van je game.  

//Plaats in je readme een animated gif van je gameplay (+- 10 sec.) waarin de implementatie van je textures en sprites goed te zien is.

Ik heb geen effecten of animaties.
Hieronder zie je een Gif van de gameplay waar alle sprites en art naar voren komt.
Als ik meer tijd had had ik graag effecten toegevoegd.

![Gameplay gif](/GameplayGif.gif)

## Product 5: Issues met debug screenshots op GitHub 

//Zodra je bugs tegenkomt maak je een issue aan op github. In de issue omschrijf je het probleem en je gaat proberen via breakpoints te achterhalen wat het probleem is. Je maakt screenshot(s) van het debuggen op het moment dat je via de debugger console ziet wat er mis is. Deze screenshots met daarbij uitleg over het probleem en de bijhorende oplossing post je in het bijhorende github issue. 

[Link naar issues](https://github.com/36018/Towerdefense/issues)

## Product 6: Game design met onderbouwing 

Je gebruikt een game design tool om je game design vast te leggen en te communiceren. Daarnaast onderbouw je de design keuzes ten aanzien van “playability” en “replayability” voor je game schriftelijk. 

Omschrijf per mechanic welke game design keuzes je hebt gemaakt en waarom je dit hebt gedaan.

*  **Je game bevat torens die kunnen mikken en schieten op een bewegend doel.** 

Mijn torens kunnen schieten als je een klik op de linkermuisknop. daarbij jij moet mikken.

*  **Je game bevat vernietigbare vijanden die 1 of meerderen paden kunnen volgen.**  

Mijn game heeft een stickman vijand. 
Als je de stickman genoeg raakt gaat hij dood. 
Ook volgt hij een pad gemaakt met waypoints.

*  **Een “health” systeem waarmee je levens kunt verliezen als vijanden hun doel bereiken en zodoende het spel kunt verliezen.** 

Links onderin het spel is er een healthbar één voor de enemy en één voor eindpup. 
Als deze healthbar leeg is van of de enemy of pup dan krijg je een andere screen te zien.
Enemy is dood = win screen
Eindpup is dood = lose screen

## 7 en 8 hebben we geen les over gehad

Dus deze sla ik over

## Product 9: SCRUM planning inschatting 

Je maakt een SCRUM planning en geeft daarbij een inschatting aan elke userstory d.m.v storypoints / zelf te bepalen eenheden. (bijv. Storypoints, Sizes of tijd) aan het begin van een nieuwe sprint update je deze inschatting per userstory. 

Plaats in de readme een link naar je trello en **zorg ervoor dat je deze openbaar maakt**

[Trello link](https://trello.com/b/O4jWqeXq/towerdefense)

