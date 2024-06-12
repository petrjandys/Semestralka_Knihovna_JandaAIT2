# Knihovna

Aplikace Knihovna je jednoduchý systém pro správu knihovny vytvořený v jazyce C# s použitím SQLite databáze. Tento projekt zahrnuje správu knih, uživatelů a půjček. Projekt byl vytvořen v rámci předmětu Základy programování.

## Funkce

- Přidávání, mazání a zobrazení knih.
- Registrace, validace a správa uživatelů (admin a běžní uživatelé).
- Půjčování a vracení knih.
- Zobrazení knih půjčených uživateli.
- Možnost změny hesla pro uživatele.
- Správa knihovny pro administrátory.

## Použití
### Před spuštením
- Aplikace využívá .Net Framework 4.7.2
- před prvnotním spuštěním je třeba projekt buildnout `F6`, aby byly staženy a nastaveny všechny závislosti

### Prvotní spuštění

Při prvním spuštění se vytvoří SQLite databáze `library.db` a inicializují se tabulky pro uživatele, knihy a půjčky.  
Automaticky se vytvoří výchozí administrátorský účet:
- Uživatelské jméno: `admin`
- Heslo: `admin`

Po přihlášení s výchozím administrátorským účtem budete vyzváni ke změně hesla.

### Přihlášení

1. Kliknutím na tlačítko Přihlásit se
2. Přihlaste se pomocí uživatelského jména a hesla
3. Pokud jste administrátor, budete přesměrováni na hlavní administrátorské okno. Pokud jste běžný uživatel, otevře se uživatelské okno

### Administrátorské funkce

- Přidávání a mazání knih
- Registrace nových uživatelů
- Správa uživatelů včetně změny hesel a mazání uživatelů
- Zobrazení knih půjčených konkrétním uživatelem

### Uživatelské funkce

- Půjčování a vracení knih
- Zobrazení seznamu všech dostupných knih
- Zobrazení seznamu půjčených knih
- Změna vlastního hesla

Tento README byl vytvořen pomocí [Readme Editoru](https://pandao.github.io/editor.md/en.html).


