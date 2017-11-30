%% colour_plot
% COLOUR_PLOT Plots the results of the 2D FEA.
function colour_plot(nodes,elements,sigma)

[nnodes,~,~] = size(nodes);
[nelements,~,~] = size(elements);

%%
% Add z-coordinates to the 2D nodes
nodes(:,4) = zeros(nnodes,1);

%%
% Create a figure and give it a scatter plot with the nodes
figure('Name','Axial Stress');
scatter3(nodes(:,2),nodes(:,3),nodes(:,4),'*');
cmap = jet(nelements);

index = [1:nelements].';
sigma = [index sigma];
sigma = sortrows(sigma,2);

for k = 1:nelements
    
    idx = sigma(k,1);
    x = [nodes(elements(idx,2),2),nodes(elements(idx,3),2)];
    y = [nodes(elements(idx,2),3),nodes(elements(idx,3),3)];
    line(x,y,[0,0],'Color',cmap(k,:),'LineWidth',2.5);
    
end
view(0,90);
colorbar;
pbaspect([1.35 1 1]);
caxis([min(sigma(:,2)),max(sigma(:,2))]);
title('Axial Stress (MPa)');
xlabel('x-coordinate (mm)');
ylabel('y-coordinate (mm)');

end