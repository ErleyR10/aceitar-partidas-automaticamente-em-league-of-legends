# aceitar-partidas-automaticamente-em-league-of-legends

(Gostaria de deixar claro que Esse e o meu primeiro projeto usando c#, sou inciante em programação e estou buscando evoluir praticando.)

Português BR: Um programa Windows Forms desenvolvido no Visual Studio que aceita automaticamente as partidas diretamente do cliente do jogo (muito útil quando você vai pegar um café e não quer perder seus preciosos 5 minutos de espera por uma partida...). Basicamente, utilizei a biblioteca Aforge.Net, System Drawing Image e 32Dll!

English: A Windows Forms program created in Visual Studio that automatically accepts game matches directly from the game client (very useful when you're grabbing a coffee and don't want to lose your precious 5 minutes waiting for a match...). Essentially, I used the Aforge.Net library, System Drawing Image, and 32Dll!

Todas as bibliotecas usadas estão disponíveis no NuGet, caso você precise.

All the libraries used are available on NuGet, in case you need them

O algoritmo receberá uma pequena imagem bitmap e realizará uma busca por uma correspondência em uma captura de uma 'parte específica' da tela do desktop. Caso seja encontrada uma correspondência, será disparado um clique preciso no meio da imagem encontrada para aceitar. Após isso, o loop em que isso está inserido continuará funcionando por 50 segundos para garantir que a partida foi iniciada e que não haverá outra correspondência.

The algorithm will receive a small bitmap image and perform a search for a match in a capture of a 'specific part' of the desktop screen. If a match is found, a precise click will be triggered in the middle of the found image to accept. After that, the loop in which this is embedded will continue running for 50 seconds to ensure that the match has started and there won't be another match.

Bom uso e obrigado por Ler! <3

continuarei atualizando!
