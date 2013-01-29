
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SerijjnyeNomera")]
	[Route("/Catalogs/SerijjnyeNomera/{Code}")]
	public class SerijjnyeNomeraRequest/*��������������������*/: V82.�����������������.��������������,IReturn<SerijjnyeNomeraRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SerijjnyeNomeraResponse//�������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SerijjnyeNomeras")]
	[Route("/Catalogs/SerijjnyeNomeras/{Codes}")]
	public class SerijjnyeNomerasRequest/*��������������������*/: IReturn<List<SerijjnyeNomeraRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SerijjnyeNomerasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SerijjnyeNomerasResponse//�������������������
	{
		public string Result {get;set;}
	}


	public class SerijjnyeNomeraService /*��������������������*/ : Service
	{
		public object Any(SerijjnyeNomeraRequest request)
		{
			return new SerijjnyeNomeraResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SerijjnyeNomeraRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������.�����������(���������);
				if (������ == null)
				{
					return new SerijjnyeNomeraResponse() {Result = "�������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������.�����������(1);
			}
		}

		public object Get(SerijjnyeNomerasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������.�����������(���������);
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
