Feature: Definitiva
	Para saber si realmente puedo gano o pierdo alguna materia
	Como Estudiante
	Quiero que me den la nota definitiva de una materia

@mytag
Scenario: Calcular nota definitiva
	Given Yo ingrese la primera nota 4.5 en la CalculAnibal
	And Yo ingrese la segunda nota 3.3 en la CalculAnibal
	And Yo ingrese la tercera nota 3.4 en la CalculAnibal
	When Yo presiono Calcular
	Then el resultado deber ser 3.7 en la pantalla

@mytag
Scenario: Calcular otra nota definitiva cuando el estudiante pierde
	Given Yo ingrese la primera nota 2.4 en la CalculAnibal
	And Yo ingrese la segunda nota 2.4 en la CalculAnibal
	And Yo ingrese la tercera nota 2.4 en la CalculAnibal
	When Yo presiono Calcular
	Then el resultado deber ser 2.4 en la pantalla
