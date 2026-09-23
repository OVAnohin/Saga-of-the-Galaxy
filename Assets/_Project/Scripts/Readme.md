pplication — запуск игры, Bootstrap, меню, переходы между состояниями приложения.
Game — сама игровая партия: GameState, игроки, ход, команды и т. п.
Domain — предметный мир, который мы сейчас постепенно описываем: Galaxy, StarSystem, Planet, Race, Empire, Technology и т. д.

Assets
└── _Project
    └── Scripts
        ├── Application
        │   ├── Bootstrap
        │   └── MainMenu
        │
        ├── Game
        │   ├── State
        │   ├── Players
        │   └── Rules
        │
        └── Domain
            ├── World
            │   ├── Galaxy
            │   ├── StarSystem
            │   └── Planet
            │
            ├── Civilization
            │   ├── Race
            │   ├── Empire
            │   └── Colony
            │
            └── Technology