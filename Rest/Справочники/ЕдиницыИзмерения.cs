
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/EdinicyIzmereniya")]
	[Route("/Catalogs/EdinicyIzmereniya/{Code}")]
	public class EdinicyIzmereniyaRequest/*����������������������*/: V82.�����������������.����������������,IReturn<EdinicyIzmereniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class EdinicyIzmereniyaResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/EdinicyIzmereniyas")]
	[Route("/Catalogs/EdinicyIzmereniyas/{Codes}")]
	public class EdinicyIzmereniyasRequest/*����������������������*/: IReturn<List<EdinicyIzmereniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public EdinicyIzmereniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class EdinicyIzmereniyasResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class EdinicyIzmereniyaService /*����������������������*/ : Service
	{
		public object Any(EdinicyIzmereniyaRequest request)
		{
			return new EdinicyIzmereniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(EdinicyIzmereniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new EdinicyIzmereniyaResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(EdinicyIzmereniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
