Bonjour

J'ai une version 2012 de visual studio, et je n'ai pas ASP.NET CORE dessus.
J'ai pas voulu l'installer pour ne pas perdre du temps et risquer d'avoir des erreurs
sur le fonctionnement de visual studio... ce qui aurait �t� chronophage...

Du coup, je n'ai pas pu avoir le bon template de projet.

De plus, sur ma version, je n'ai pas le temmplate de projet sp�cifique au web API uniquement.

J'ai donc utilis� le squelette de projet a disposition dans mon visual studio, qui cr�e, pour les web API,
un squelette de projet qui contien aussi un controleur ASP.NET MVC classique.



Pour les raisons qui pr�c�dent, j'ai pas eu beaucou de temps donc j'ai rapidement fait ce que j'ai pu dans le reste du temps imparti.
Et mon nugget n'�tant pas fonctionnel, j'ai pas pu ajouter:

- Ajouter un logger
- J'ai pas pu ajouter un conteneur de d�pendence inject�e, comme NInject par exemple.
- J'ai pas pu t�l�charger le plug in Swagger, pour avoir une bonne interface client.
- Il ne me restait plus qu'� �crire les m�thodes actions des services demand�.
- J'ai essay� de mod�liser le domaine de facon � envisager un versionning des stack, et un tracking des conditions de leur manipulation


Le controleur pour les web API ici c'est: Values