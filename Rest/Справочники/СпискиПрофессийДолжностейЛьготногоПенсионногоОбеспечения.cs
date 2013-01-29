
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniya")]
	[Route("/Catalogs/SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniya/{Code}")]
	public class SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest/*��������������������������������������������������������������*/: V82.�����������������.��������������������������������������������������������,IReturn<SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaResponse//�������������������������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyas")]
	[Route("/Catalogs/SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyas/{Codes}")]
	public class SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyasRequest/*��������������������������������������������������������������*/: IReturn<List<SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyasResponse//�������������������������������������������������������������
	{
		public string Result {get;set;}
	}


	public class SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaService /*��������������������������������������������������������������*/ : Service
	{
		public object Any(SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest request)
		{
			return new SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyaResponse() {Result = "�������������������������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������������������������������.�����������(1);
			}
		}

		public object Get(SpiskiProfessijjDolzhnostejjLgotnogoPensionnogoObespecheniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������������������������������.�����������(���������);
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
