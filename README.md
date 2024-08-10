# Projeto_gRPC
Criação de três aplicações modelo para exemplificar o
funcionamento do gRPC: Servidor gRCP + Provedor de tokens JWT + Cliente gRPC, todos em pleno funcionamento.

 O servidor gRPC exporta dois serviços, um para cálculos geométricos planos, outro para cálculos geométricos volumétricos.
 O provedor de tokens JWT exporta tokens válidos para que seja possível consumir os serviços exportados pelo gRPC Servidor, que possui um Middleware de autenticação baseado em JWT.
 O cliente gRPC importa os serviços do gRPC Servidor, consome os tokes do provedor de JWT, envia os tokens via metadados na requisição dos serviços, para dessa forma poder consumir os serviços do gRPC Servidor estando autenticado.
