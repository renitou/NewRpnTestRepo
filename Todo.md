Bonjour

J'ai une version 2012 de visual studio, et je n'ai pas ASP.NET CORE dessus.
J'ai pas voulu l'installer pour ne pas perdre du temps et risquer d'avoir des erreurs
sur le fonctionnement de visual studio... ce qui aurait été chronophage...

Du coup, je n'ai pas pu avoir le bon template de projet.

De plus, sur ma version, je n'ai pas le temmplate de projet spécifique au web API uniquement.

J'ai donc utilisé le squelette de projet a disposition dans mon visual studio, qui crée, pour les web API,
un squelette de projet qui contien aussi un controleur ASP.NET MVC classique.



Pour les raisons qui précèdent, j'ai pas eu beaucou de temps donc j'ai rapidement fait ce que j'ai pu dans le reste du temps imparti.
Et mon nugget n'étant pas fonctionnel, j'ai pas pu ajouter:

- Ajouter un logger
- J'ai pas pu ajouter un conteneur de dépendence injectée, comme NInject par exemple.
- J'ai pas pu télécharger le plug in Swagger, pour avoir une bonne interface client.
- Il ne me restait plus qu'à écrire les méthodes actions des services demandé.
- J'ai essayé de modéliser le domaine de facon à envisager un versionning des stack, et un tracking des conditions de leur manipulation


Le controleur pour les web API ici c'est: Values