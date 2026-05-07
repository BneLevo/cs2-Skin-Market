# Documentation simple du projet CS2 Skins Market

## Description du projet
Ce projet est une application winform en C# pour acheter des skins CS2.  
J'ai utilisé une architecture avec des couches:
- `UI` (les forms)
- `Business` (les services)
- `Data` (MongoDB + repositories)
- `Core` (modèles et session)

## Structure du projet
```text
cs2-skins-market/
|-- cs2-skins-market/
|   |-- Business/
|   |   |-- Interfaces/
|   |   |   |-- IAuthService.cs
|   |   |   |-- IPurchaseService.cs
|   |   |   `-- ISkinService.cs
|   |   `-- Services/
|   |       |-- AuthService.cs
|   |       |-- PurchaseService.cs
|   |       `-- SkinManager.cs
|   |-- Core/
|   |   |-- Models/
|   |   |   |-- AppUser.cs
|   |   |   |-- Skin.cs
|   |   |   `-- UserInventoryItem.cs
|   |   `-- AppSession.cs
|   |-- Data/
|   |   |-- Interfaces/
|   |   |   |-- IUserRepository.cs
|   |   |   |-- ISkinRepository.cs
|   |   |   `-- IInventoryRepository.cs
|   |   |-- Repositories/
|   |   |   |-- MongoUserRepository.cs
|   |   |   |-- MongoSkinRepository.cs
|   |   |   `-- MongoInventoryRepository.cs
|   |   |-- DbInitializer.cs
|   |   `-- MongoDBconnect.cs
|   `-- UI/
|       |-- Forms/
|       `-- UserControls/
`-- docs/
    `-- documentation.md
```

## SOLID: parties appliquées dans notre projet

### 1) S - Single Responsibility Principle
Idée: une classe fait une seule chose principale.

- `AuthService` gère l'authentification.
- `MongoUserRepository` gère l'accès base de donnee pour les utilisateurs.
- `SkinManager` gère les opérations de lecture/filtrage des skins.

Exemple:
```csharp
public class SkinManager : ISkinService
{
    private readonly ISkinRepository _skinRepo;

    public SkinManager()
    {
        _skinRepo = new MongoSkinRepository();
    }

    public List<Skin> GetAllSkins()
    {
        return _skinRepo.GetAllSkins();
    }
}
```

### 2) O - Open/Closed Principle
Idée: on peut étendre le comportement sans casser l'existant.

On utilise des interfaces comme `ISkinRepository` et `IUserRepository`.  
Si on veut une autre implémentation (par exemple SQL), on peut créer une nouvelle classe qui implémente la même interface.

Exemple:
```csharp
public interface ISkinRepository
{
    List<Skin> GetAllSkins();
    void InsertMany(List<Skin> initialData);
    List<Skin> GetSkinsByFilter(string name, double min, double max);
    long GetCount();
}
```

### 3) L - Liskov Substitution Principle
Idée: une implémentation concrète doit pouvoir remplacer son interface sans casser le code.

Par exemple, le service utilise `IUserRepository`.  
Donc `MongoUserRepository` peut etre remplacé par une autre implémentation (ex: `SqlUserRepository`) tant qu'elle respecte le contrat.

### 4) I - Interface Segregation Principle
Idée: préférer des interfaces petites et ciblées.

Dans le projet, on a séparé:
- `IUserRepository`
- `ISkinRepository`
- `IInventoryRepository`

C'est mieux que faire une énorme interface avec toutes les méthodes.

### 5) D - Dependency Inversion Principle
Idée: dépendre des abstractions, pas des classes concrètes.

Le projet utilise déjà des interfaces, même si les objets sont encore créés manuellement avec `new`

Exemple:
```csharp
public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;

    public AuthService()
    {
        _userRepository = new MongoUserRepository();
    }
}
```

## Pourquoi le Singleton pattern
J'ai choisi Singleton dans `MongoDBconnect` pour avoir une seule instance de `MongoClient`.

Pourquoi c'est utile:
- evite de créer plusieurs connexions inutiles
- plus simple pour partager la connexion dans toute l'application
- meilleur pour la performance et la stabilité

Exemple:
```csharp
public static MongoClient Instance()
{
    if (_instance == null)
    {
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new MongoClient("mongodb://localhost:27018");
            }
        }
    }
    return _instance;
}
```

## Pourquoi le Repository pattern
J'ai choisi Repository pattern pour séparer la logique métier et la logique accès données.

Pourquoi c'est utile:
- quand il y a beaucoup de fichiers, c'est plus propre et mieux organisé
- plus lisible
- si un jour on veut changer de base de données (par exemple MongoDB vers SQL), le changement est plus rapide parce qu'on remplace surtout les repositories

Exemple d'utilisation:
```csharp
public List<Skin> GetSkinsByFilter(string name, double min, double max)
{
    return _skinRepo.GetSkinsByFilter(name, min, max);
}
```
