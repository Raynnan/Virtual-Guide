# Virtual-Guide
Um chatbot amigável desenvolvido em C# com Windows Forms, impulsionado pela inteligência artificial do Google (Gemini) através da biblioteca Mscc.GenerativeAI.

## Visão Geral
O Virtual-Guide é um assistente virtual desktop projetado para fornecer informações, responder a perguntas e auxiliar os usuários em diversas tarefas diretamente do seu computador Windows. Utilizando a poderosa IA do Google, o chatbot oferece interações conversacionais fluidas e inteligentes. A interface gráfica intuitiva, construída com Windows Forms, torna a experiência do usuário agradável e acessível.

## Funcionalidades Principais
- Interação Conversacional: Dialogue com o chatbot em linguagem natural para obter respostas e informações.
- Powered by Gemini AI: Beneficie-se da inteligência e do vasto conhecimento do modelo Gemini.
- Integração com Mscc.GenerativeAI: Utiliza a biblioteca para uma comunicação eficiente com a API do Gemini.
- Interface Windows Forms: Desfrute de uma interface gráfica familiar e fácil de usar no ambiente Windows.
- Potencial para Expansão: A arquitetura permite a adição de novas funcionalidades e integrações futuras.

## Tecnologias Utilizadas
- C#: Linguagem de programação principal.
- .NET Framework (ou .NET): Plataforma de desenvolvimento.
- Windows Forms: Framework para a criação da interface gráfica desktop.
- Mscc.GenerativeAI: Biblioteca .NET para interagir com a API do Gemini.

## Pré-requisitos
### *Antes de executar o Virtual-Guide, certifique-se de ter o seguinte instalado:*

- Visual Studio: Um ambiente de desenvolvimento integrado (IDE) para construir e executar aplicações C#.
- .NET Framework (ou .NET) SDK: O kit de desenvolvimento de software para .NET.
- Acesso à Internet: Necessário para a comunicação com a API do Gemini.
- Chave de API do Gemini: Você precisará obter e configurar uma chave de API do Google Cloud para utilizar o modelo Gemini.

## Como Utilizar

1. **Clone o Repositório (se aplicável):**
```bash
   git clone https://github.com/Raynnan/Virtual-Guide.git
   cd Virtual-Guide
```

2. **Abra a Solução no Visual Studio:**
    - Navegue até a pasta do projeto e abra o arquivo `.sln.`

3. **Restaure os Pacotes NuGet:** 
    - No Visual Studio, vá em `Ferramentas` -> `Gerenciador de Pacotes NuGet` -> `Restaurar Pacotes NuGet.` Isso garantirá que a biblioteca `Mscc.GenerativeAI` e outras dependências sejam baixadas.

4. **Configure a Chave de API do Gemini:**
    - Localize no código-fonte onde a chave de API é utilizada.
    - Substitua o espaço reservado pela sua chave de API do Google Cloud. **Tenha cuidado para não expor sua chave publicamente**. Considere o uso de variáveis de ambiente ou
    arquivos de configuração seguros para armazenar a chave.

5. **Execute o Projeto:**
    - Pressione `F5` no Visual Studio ou clique no botão "Iniciar" para compilar e executar o Virtual-Guide.

6. **Interaja com o Chatbot:**
    - A janela do Virtual-Guide será exibida, permitindo que você digite suas perguntas e receba respostas do Gemini.