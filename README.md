# Documentação RTF (Resume To Flashcard)

## Descrição Geral

Aplicação console em C# que lê um arquivo texto com um resumo, gera flashcards automaticamente utilizando uma API de
IA (Gemini), e adiciona esses flashcards em um deck específico do Anki via AnkiConnect.

---

## Fluxo Principal

1. Valida se o comando é "generate".
2. Exibe aviso para garantir que o Anki e AnkiConnect estejam ativos.
3. Solicita e valida o caminho do arquivo com o resumo, **usando o diretório base do usuário atual (UserProfile) como base.**
4. Carrega configurações da API Gemini (URL e API Key).
5. Solicita e valida o nome do deck no Anki.
6. Gera um prompt para a API Gemini criar notas de flashcards em JSON.
7. Envia o prompt para a API Gemini e obtém as notas.
8. Envia as notas para o Anki via AnkiConnect para adicioná-las no deck.
9. Exibe mensagem de sucesso ou erro e encerra.

---

## Requisitos

* Anki deve estar rodando localmente com AnkiConnect ativado ([http://localhost:8765](http://localhost:8765)).
* Arquivo de resumo existente e não vazio.
* Configuração válida no `appsettings.json` com a chave `GeminiOptions` contendo `ApiKey` e `Url`.
* Deck existente no Anki com nome informado pelo usuário.

---

## Exemplos de uso

Linha de comando:

```bash
dotnet run generate
```

Após isso, seguir as instruções para informar o caminho do arquivo de resumo e o nome do deck.