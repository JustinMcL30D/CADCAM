function [SF_mod, SF_lan] = Fatigue_Loading(sigma_max, sigma_min, S_e, S_ut, S_y)

%%
% Calculate alternating and midrange stresses from Equations (\ref{eq:sigma_a}) and (\ref{eq:sigma_m})
sigma_a = (sigma_max - sigma_min)/2;
sigma_m = (sigma_max + sigma_min)/2;

%%
% Find SF for modified goodman equation from Equation (\ref{eq:mod_good})
SF_mod = 1/(sigma_a/S_e + sigma_m/S_ut);

%%
% Find SF for Langer Yield from Equation (\ref{eq:langer})
SF_lan = S_y/(sigma_a + sigma_m);

end