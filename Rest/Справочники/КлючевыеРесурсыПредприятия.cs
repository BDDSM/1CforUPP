
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlyuchevyeResursyPredpriyatiya")]
	[Route("/Catalogs/KlyuchevyeResursyPredpriyatiya/{Code}")]
	public class KlyuchevyeResursyPredpriyatiyaRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<KlyuchevyeResursyPredpriyatiyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlyuchevyeResursyPredpriyatiyaResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlyuchevyeResursyPredpriyatiyas")]
	[Route("/Catalogs/KlyuchevyeResursyPredpriyatiyas/{Codes}")]
	public class KlyuchevyeResursyPredpriyatiyasRequest/*��������������������������������*/: IReturn<List<KlyuchevyeResursyPredpriyatiyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlyuchevyeResursyPredpriyatiyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlyuchevyeResursyPredpriyatiyasResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class KlyuchevyeResursyPredpriyatiyaService /*��������������������������������*/ : Service
	{
		public object Any(KlyuchevyeResursyPredpriyatiyaRequest request)
		{
			return new KlyuchevyeResursyPredpriyatiyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlyuchevyeResursyPredpriyatiyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new KlyuchevyeResursyPredpriyatiyaResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(KlyuchevyeResursyPredpriyatiyasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
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
