import json

with open("dados.json", "r") as arquivo:
    dados = json.load(arquivo)

dias_com_faturamento = [dia["valor"] for dia in dados if dia["valor"] > 0]

menor = min(dias_com_faturamento)
maior = max(dias_com_faturamento)
media = sum(dias_com_faturamento) / len(dias_com_faturamento)
dias_acima_da_media = sum(1 for valor in dias_com_faturamento if valor > media)

print(f"Menor faturamento: R$ {menor:.2f}")
print(f"Maior faturamento: R$ {maior:.2f}")
print(f"Dias com faturamento acima da média ({media:.2f}): {dias_acima_da_media} dias")
