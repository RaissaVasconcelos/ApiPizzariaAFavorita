# 🍕 Pizzaria API

API REST desenvolvida com **NestJS**, seguindo boas práticas de arquitetura, escalabilidade e organização de código.

O objetivo deste projeto é simular um sistema real de gerenciamento para pizzarias, utilizando tecnologias amplamente adotadas no mercado e aplicando conceitos como autenticação, multi-tenancy, arquitetura modular e boas práticas de desenvolvimento.

---

# 🚀 Stack

- Bun
- NestJS
- TypeScript
- PostgreSQL
- Prisma ORM
- Zod
- Biome
- Husky
- Commitlint
- Lint Staged
- Docker

---

# ✅ Configurações concluídas

## Projeto

- [x] Criação do projeto com NestJS
- [x] Configuração utilizando Bun
- [x] Organização inicial da estrutura do projeto

---

## Qualidade de Código

- [x] Biome
- [x] Prettier
- [x] EditorConfig
- [x] Husky
- [x] Lint Staged
- [x] Commitlint
- [x] Padrão de Commits (Conventional Commits)

---

## Configuração da Aplicação

- [x] ConfigModule
- [x] Variáveis de ambiente
- [x] Validação do `.env` utilizando Zod
- [x] Organização da pasta `config`

---

## Banco de Dados

- [x] PostgreSQL
- [x] Docker Compose
- [x] Prisma ORM
- [x] Prisma Service
- [x] Prisma Module

---

# 📂 Estrutura atual

```text
src/
│
├── config/
├── database/
├── modules/
├── app.module.ts
└── main.ts

prisma/
│
├── schema.prisma
└── migrations/
```

---

# 🛣️ Roadmap

## 1. Modelagem do Banco de Dados

- [ ] Levantamento dos requisitos
- [ ] Definição das entidades
- [ ] Definição dos relacionamentos
- [ ] Modelagem do domínio
- [ ] Criação do schema do Prisma
- [ ] Primeira Migration

---

## 2. Autenticação

- [ ] Cadastro de usuários
- [ ] Login
- [ ] Hash de senha utilizando Argon2
- [ ] JWT
- [ ] Refresh Token
- [ ] Guards
- [ ] Roles
- [ ] Permissões

---

## 3. Multi-Tenant

- [ ] Empresa (Tenant)
- [ ] Associação de usuários
- [ ] Isolamento dos dados
- [ ] Middleware para identificação do Tenant

---

## 4. Clientes

- [ ] CRUD
- [ ] Endereços
- [ ] Telefones
- [ ] Histórico de pedidos

---

## 5. Produtos

- [ ] Categorias
- [ ] Produtos
- [ ] Tamanhos
- [ ] Sabores
- [ ] Bordas
- [ ] Ingredientes
- [ ] Adicionais

---

## 6. Pedidos

- [ ] Abertura de pedido
- [ ] Itens
- [ ] Observações
- [ ] Status
- [ ] Histórico

---

## 7. Pagamentos

- [ ] Dinheiro
- [ ] PIX
- [ ] Cartão
- [ ] Controle de pagamento

---

## 8. Dashboard

- [ ] Estatísticas
- [ ] Faturamento
- [ ] Produtos mais vendidos
- [ ] Pedidos por período

---

## 9. Documentação

- [ ] Swagger
- [ ] Exemplos de requisição
- [ ] Documentação das rotas

---

## 10. Testes

- [ ] Testes Unitários
- [ ] Testes de Integração
- [ ] Testes End-to-End

---

## 11. Deploy

- [ ] Docker
- [ ] Docker Compose
- [ ] CI/CD
- [ ] Ambiente de Produção

---

# 🎯 Objetivos do Projeto

Este projeto tem como objetivo aplicar conceitos utilizados em sistemas reais, tais como:

- Arquitetura Modular
- SOLID
- Clean Code
- Boas práticas com NestJS
- Domain Driven Design (DDD)
- Multi-Tenant
- Autenticação JWT
- Validação com Zod
- ORM com Prisma
- Docker
- Testes Automatizados
- Escalabilidade
- Manutenibilidade

---

# 📌 Status

🚧 Em desenvolvimento.