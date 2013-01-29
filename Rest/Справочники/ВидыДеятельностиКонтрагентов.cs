
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyDeyatelnostiKontragentov")]
	[Route("/Catalogs/VidyDeyatelnostiKontragentov/{Code}")]
	public class VidyDeyatelnostiKontragentovRequest/*����������������������������������*/: V82.�����������������.����������������������������,IReturn<VidyDeyatelnostiKontragentovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyDeyatelnostiKontragentovResponse//���������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyDeyatelnostiKontragentovs")]
	[Route("/Catalogs/VidyDeyatelnostiKontragentovs/{Codes}")]
	public class VidyDeyatelnostiKontragentovsRequest/*����������������������������������*/: IReturn<List<VidyDeyatelnostiKontragentovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyDeyatelnostiKontragentovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyDeyatelnostiKontragentovsResponse//���������������������������������
	{
		public string Result {get;set;}
	}


	public class VidyDeyatelnostiKontragentovService /*����������������������������������*/ : Service
	{
		public object Any(VidyDeyatelnostiKontragentovRequest request)
		{
			return new VidyDeyatelnostiKontragentovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyDeyatelnostiKontragentovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyDeyatelnostiKontragentovResponse() {Result = "���������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������������.�����������(1);
			}
		}

		public object Get(VidyDeyatelnostiKontragentovsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������������.�����������(���������);
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
