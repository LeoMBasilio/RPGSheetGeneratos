# RPGSheetGeneratos
<h1> API de Geração de Fichas de RPG </h1>
<p>
  A API de Geração de Fichas de RPG é uma ferramenta poderosa para criar fichas de personagens de jogos de RPG de forma rápida e fácil. Esta documentação fornecerá informações sobre como usar a API, seus recursos e requisitos de instalação.
</p>
<h2>Visão Geral</h2>
<p>
A API de Geração de Fichas de RPG permite que os desenvolvedores gerem automaticamente fichas de personagens de RPG, preenchendo informações como nome, raça, classe, habilidades, estatísticas e outros detalhes personalizáveis. Ela é útil para criar personagens não jogadores (NPCs) ou para dar aos jogadores a capacidade de gerar rapidamente fichas de seus próprios personagens.
</p>

<h2>Recursos</h2>
<p>
A API oferece os seguintes recursos principais:
</p>
<li>
  Geração de Personagem: Crie uma ficha de personagem completa com base em parâmetros personalizáveis.
  Listagem de Classes e Raças: Consulte a lista de classes e raças disponíveis para personalização.
  Habilidades e Estatísticas: Defina habilidades, estatísticas e características específicas para o personagem.
</li>

<h1>Uso Basico</h1>
<h2>Solicitação</h2>
<p>
  GET http://IP/RPG
</p>
<h2>REsposta</h2>
<p>
  {
    "id": 0,<br>
    "name": "Eldarion",<br>
    "raca": "Aven",<br>
    "sexo": "Masculino",<br>
    "idade": 105,<br>
    "altura": 1.50,<br>
    "estadoCivil": "Casado",<br>
    "ocupacao": "Espadachim",<br>
    "alinhamento": "Leal e Mau",<br>
    "personalidade": "Corajoso",<br>
    "forca": 14,<br>
    "destreza": 10,<br>
    "constituicao": 16,<br>
    "inteligencia": 15,<br>
    "sabedoria": 5,<br>
    "carisma": 10<br>
  }
</p>
