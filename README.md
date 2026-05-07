# cs2-skins-market

Application desktop (WinForms) de type “marketplace” pour acheter et gérer des skins CS2, avec un système de comptes et une base de données MongoDB.

## Fonctionnalités

- Inscription et connexion des utilisateurs
- Gestion d’un budget (dépôt de fonds)
- Catalogue de skins (consultation et filtres)
- Panier (ajouter/retirer des skins, puis achat)
- Inventaire utilisateur (skins achetés, triés par date d’achat)

## Prérequis

- Windows (projet WinForms)
- .NET SDK version `net10.0-windows`
- Docker (pour MongoDB)

## Lancer MongoDB (Docker)

1. `git clone https://github.com/BneLevo/cs2-Skin-Market.git`

2. `cd cs2-Skin-Market`

3. `docker compose up -d`

## Démarrer l’application

Ouvrez Visual Studio et lancez le projets

ou

`dotnet build`  
`dotnet run --project cs2-skins-market/cs2-skins-market.csproj`

## Données MongoDB

Le code utilise la base MongoDB `cs2_skins_market` :

- Collection `Skins`
  - Collection pour le stockage des skins
      - _id
      - name
      - img
      - price
      - item
      - skinName
- Collection `Users`
  - Collection pour le stockage des utilisateurs
      - _id
      - username
      - passwordHash
      - budget
- Collection `Inventory`
  - Collection pour le stockage des skins que nous avions acheté
      - _id
      - username
      - skinId
      - name
      - price
      - purchasedAt

## Forms

1. `LoginForm`
   - Authentifie l’utilisateur
2. `Form1` (market)
   - permet de parcourir des skins et d’en ajouter au panier
3. `CartForm`
   - affiche le panier, total, budget
4. `InventoryForm`
   - Affiche l’inventaire
5. `WalletForm`
   - Dépôt de fonds
