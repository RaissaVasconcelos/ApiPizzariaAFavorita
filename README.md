# 🍕 Pizzaria API

API REST para gerenciamento de uma pizzaria utilizando **ASP.NET Core**, **DDD** e **Entity Framework Core**.

---

# 📁 Arquitetura

```text
Pizzaria.Api
        ↓
Pizzaria.Application
        ↓
Pizzaria.Domain
        ↑
Pizzaria.Infrastructure.Data
        ↑
Pizzaria.Infrastructure.IoC
```

---

# ✅ Implementado

## Domínio

### Categoria
- [x] Entidade `Category`

### Produtos
- [x] Entidade `Product`
- [x] Validações de domínio:
  - Nome obrigatório
  - Preço maior que zero
  - Categoria obrigatória
- [x] Controle de ativação do produto

### Complementos
- [x] Entidade `Complement`
- [x] Catálogo reutilizável de complementos

### Grupos de Complementos
- [x] Entidade `ProductComplementGroup`
- [x] Definição de:
  - Nome do grupo
  - Quantidade mínima
  - Quantidade máxima
  - Grupo obrigatório ou opcional
- [x] Adicionar grupo ao produto
- [x] Remover grupo do produto

### Produto x Complementos
- [x] Entidade `ProductComplement`
- [x] Associação entre:
  - Produto
  - Grupo de complemento
  - Complemento
- [x] Preço individual por complemento
- [x] Adicionar complemento ao grupo
- [x] Remover complemento do grupo

### DDD
- [x] Aggregate Root: `Product`
- [x] Encapsulamento das coleções com `IReadOnlyCollection`
- [x] Regras de negócio centralizadas nas entidades
- [x] Interfaces de repositórios do domínio

---

# 📊 Modelo Atual

```text
Category
    │
    ▼
Product
    │
    └── ProductComplementGroup
            │
            └── ProductComplement
                    │
                    └── Complement
```

---

# 🍕 Exemplo

```text
Pizza Média
│
├── Sabores
│   ├── Min: 1
│   ├── Max: 3
│   ├── Calabresa
│   ├── Portuguesa
│   └── Frango
│
└── Borda
    ├── Min: 0
    ├── Max: 1
    ├── Catupiry (+8)
    └── Cheddar (+8)
```

---

# 🚧 Próximos Passos

## Domínio
- [ ] Criar `DomainException`
- [ ] Revisar e refinar validações das entidades

## Persistência
- [ ] Criar `PizzariaDbContext`
- [ ] Configurar Fluent API (`EntityTypeConfiguration`)
- [ ] Configurar relacionamentos
- [ ] Criar primeira migration

## Repositórios
- [ ] Implementar `IProductRepository`
- [ ] Implementar `ICategoryRepository`
- [ ] Implementar `IComplementRepository`
- [ ] Implementar `ICustomerRepository`
- [ ] Implementar `IOrderRepository`

## Aplicação
- [ ] Criar DTOs
- [ ] Criar Services/Casos de Uso
- [ ] Configurar AutoMapper (opcional)

## API
- [ ] Criar Controllers
- [ ] Configurar Swagger
- [ ] Tratamento global de exceções

## Próximos Domínios
- [ ] Customer
- [ ] Address (Value Object)
- [ ] Order
- [ ] OrderItem
- [ ] Controle de status do pedido
- [ ] Cálculo de preço final do pedido

---

# 🎯 Objetivo Atual

```text
✓ Domínio modelado
↓
□ Persistir entidades com EF Core
↓
□ Criar casos de uso
↓
□ Expor endpoints da API
↓
□ Implementar pedidos e regras de negócio
```