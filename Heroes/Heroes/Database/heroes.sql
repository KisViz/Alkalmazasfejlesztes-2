CREATE TABLE hero(
 id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
 name text NOT NULL,
 hero_name text NOT NULL,
 hero_power text NOT NULL,
 age integer NOT NULL,
 UNIQUE(hero_name)
);
