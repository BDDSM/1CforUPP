
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyCFO")]
	[Route("/Catalogs/VidyCFO/{Code}")]
	public class VidyCFORequest/*�������������*/: V82.�����������������.�������,IReturn<VidyCFORequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyCFOResponse//������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyCFOs")]
	[Route("/Catalogs/VidyCFOs/{Codes}")]
	public class VidyCFOsRequest/*�������������*/: IReturn<List<VidyCFORequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyCFOsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyCFOsResponse//������������
	{
		public string Result {get;set;}
	}


	public class VidyCFOService /*�������������*/ : Service
	{
		public object Any(VidyCFORequest request)
		{
			return new VidyCFOResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyCFORequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������.�����������(���������);
				if (������ == null)
				{
					return new VidyCFOResponse() {Result = "������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������.�����������(1);
			}
		}

		public object Get(VidyCFOsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������.�����������(���������);
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
